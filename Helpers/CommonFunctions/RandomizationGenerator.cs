
using System.Security.Cryptography;
using System.Text;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public class RandomizationGenerator
    {
        private static readonly byte[] Key = Encoding.ASCII.GetBytes("OvulaeSecretKey!"); // Must be 16 chars for AES-128
        private static readonly byte[] IV = Encoding.ASCII.GetBytes("OvulaeInitVector!"); // Also 16 chars

        private static readonly Random _random = new();

        #region Randoms Power House

        private static byte[] EncryptStringToBytes(string plainText)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;
            var encryptor = aes.CreateEncryptor();

            var inputBytes = Encoding.UTF8.GetBytes(plainText);
            return encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
        }

        private static string DecryptBytesToString(byte[] encryptedBytes)
        {
            using var aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;
            var decryptor = aes.CreateDecryptor();

            var decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            return Encoding.UTF8.GetString(decryptedBytes);
        }

        private static string Base36Encode(byte[] bytes)
        {
            var bigInt = new System.Numerics.BigInteger(bytes.Append((byte)0).ToArray()); // Ensure positive
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var result = new StringBuilder();
            while (bigInt > 0)
            {
                bigInt = System.Numerics.BigInteger.DivRem(bigInt, 36, out var remainder);
                result.Insert(0, chars[(int)remainder]);
            }

            return result.ToString();
        }

        private static byte[] Base36Decode(string input)
        {
            const string chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var value = new System.Numerics.BigInteger(0);
            foreach (var c in input.ToUpper())
            {
                value *= 36;
                value += chars.IndexOf(c);
            }

            var bytes = value.ToByteArray();
            if (bytes[^1] == 0)
                bytes = bytes[..^1]; // Remove extra zero added for positivity

            return bytes;
        }

        private static string GenerateCodeFromEmail(string email)
        {
            // Use SHA256 hash and convert to base36 (or base16)
            using var sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(email));

            // Use first 4 bytes to build 6 alphanumeric characters
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            var sb = new StringBuilder();

            for (int i = 0; i < 6; i++)
            {
                int index = hashBytes[i] % chars.Length;
                sb.Append(chars[index]);
                if (i == 2) sb.Append('-'); // insert dash after 3 chars
            }

            return sb.ToString();
        }

        #endregion

        public static (string AndroidLink, string IOSLink) GetReferralLinksFromEmail(string affiliateUserEmail)
        {
            string code = GenerateCodeFromEmail(affiliateUserEmail.ToLower().Trim());

            string androidLink = $"ovandr-{code}";
            string iosLink = $"ovios-{code}";

            return (androidLink, iosLink);
        }

        public static string GetReferralIdFromEmail(string email)
        {
            try
            {
                var encryptedBytes = EncryptStringToBytes(email);
                var encoded = Base36Encode(encryptedBytes);
                return $"#REF{encoded.ToUpper()}";
            }
            catch
            {
                return "REF-###";
            }
        }

        public static string GetEmailFromReferralId(string referralId)
        {
            try
            {
                if (!referralId.StartsWith("#REF"))
                    return "";

                var base36 = referralId.Substring(4); // remove #REF
                var encryptedBytes = Base36Decode(base36);
                return DecryptBytesToString(encryptedBytes);
            }
            catch
            {
                return "";
            }
        }

        public static string GeneratePasswordFromEmail(string email)
        {
            try
            {
                using var sha256 = SHA256.Create();
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(email.ToLower().Trim()));

                const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                const string lowercase = "abcdefghijklmnopqrstuvwxyz";
                const string digits = "0123456789";
                const string specials = "!@#$";

                var passwordChars = new char[8];

                // Enforce rules
                passwordChars[0] = uppercase[hashBytes[0] % uppercase.Length];
                passwordChars[1] = lowercase[hashBytes[1] % lowercase.Length];
                passwordChars[2] = digits[hashBytes[2] % digits.Length];
                passwordChars[3] = specials[hashBytes[3] % specials.Length];

                // Fill remaining 4 chars with mixed pool for complexity
                const string allChars = uppercase + lowercase + digits + specials;
                for (int i = 4; i < 8; i++)
                {
                    passwordChars[i] = allChars[hashBytes[i] % allChars.Length];
                }

                return new string(passwordChars);
            }
            catch
            {
                return "Password1!";
            }
        }

    }
}
