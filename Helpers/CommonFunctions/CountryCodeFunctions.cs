using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvulaeShared.Helpers.CommonFunctions
{
    public class CountryCodeFunctions
    {

        public static List<string> COUNTRY_CODE_FLAG = new List<string>
        {
                // Africa (Complete)
                "🇿🇦 +27", "🇳🇬 +234", "🇰🇪 +254", "🇬🇭 +233", "🇹🇿 +255",
                "🇺🇬 +256", "🇿🇼 +263", "🇲🇼 +265", "🇧🇼 +267", "🇳🇦 +264",
                "🇪🇬 +20", "🇪🇹 +251", "🇨🇲 +237", "🇸🇩 +249", "🇸🇳 +221",
                "🇲🇱 +223", "🇨🇮 +225", "🇨🇩 +243", "🇷🇼 +250",
                "🇱🇸 +266", "🇹🇳 +216", "🇲🇦 +212", "🇩🇿 +213", "🇱🇾 +218",
                "🇧🇮 +257", "🇨🇻 +238", "🇹🇩 +235", "🇩🇯 +253", "🇬🇶 +240",
                "🇪🇷 +291", "🇸🇿 +268", "🇹🇬 +228", "🇿🇲 +260", "🇸🇴 +252",
                "🇸🇸 +211", "🇸🇹 +239", 
            
                // Europe (Complete)
                "🇬🇧 +44", "🇩🇪 +49", "🇫🇷 +33", "🇮🇹 +39", "🇪🇸 +34",
                "🇳🇱 +31", "🇧🇪 +32", "🇸🇪 +46", "🇳🇴 +47", "🇫🇮 +358",
                "🇨🇭 +41", "🇦🇹 +43", "🇷🇺 +7", "🇵🇹 +351", "🇬🇷 +30",
                "🇮🇪 +353", "🇵🇱 +48", "🇨🇿 +420", "🇸🇰 +421", "🇭🇺 +36",
                "🇷🇴 +40", "🇩🇰 +45", "🇧🇬 +359", "🇭🇷 +385", "🇱🇹 +370",
                "🇱🇻 +371", "🇪🇪 +372", "🇸🇮 +386", "🇲🇹 +356", "🇨🇾 +357",
                "🇱🇺 +352", "🇮🇸 +354", "🇦🇩 +376", "🇲🇨 +377", "🇻🇦 +379",
            
                // Asia (Complete)
                "🇮🇳 +91", "🇨🇳 +86", "🇯🇵 +81", "🇰🇷 +82", 
                "🇧🇩 +880", "🇵🇭 +63", "🇹🇭 +66", "🇻🇳 +84", "🇮🇩 +62",
                "🇲🇾 +60", "🇸🇬 +65", "🇹🇷 +90", "🇸🇦 +966", "🇦🇪 +971",
                "🇶🇦 +974", "🇮🇱 +972", "🇯🇴 +962", "🇰🇼 +965", "🇱🇧 +961",
                "🇴🇲 +968", "🇾🇪 +967", "🇮🇷 +98", "🇮🇶 +964", "🇸🇾 +963",
                "🇧🇭 +973", "🇲🇳 +976", "🇳🇵 +977", "🇱🇰 +94", "🇲🇲 +95",
                "🇰🇭 +855", "🇱🇦 +856", "🇧🇹 +975", "🇲🇻 +960", "🇧🇳 +673",
                "🇹🇱 +670", "🇵🇼 +680", "🇫🇲 +691", "🇵🇰 +92", "🇦🇫 +93",
            
                // North America (Complete)
                "🇺🇸 +1", "🇨🇦 +1", "🇲🇽 +52", "🇨🇺 +53", "🇩🇴 +1",
                "🇧🇸 +1", "🇧🇧 +1", "🇯🇲 +1", "🇹🇹 +1", "🇩🇲 +1",
                "🇬🇩 +1", "🇰🇳 +1", "🇱🇨 +1", "🇻🇨 +1", "🇦🇬 +1",
                "🇧🇿 +501", "🇨🇷 +506", "🇸🇻 +503", "🇬🇹 +502", "🇭🇳 +504",
                "🇳🇮 +505", "🇵🇦 +507", "🇭🇹 +509", "🇵🇷 +1", "🇬🇵 +590",
            
                // South America (Complete)
                "🇧🇷 +55", "🇦🇷 +54", "🇨🇱 +56", "🇨🇴 +57", "🇵🇪 +51",
                "🇺🇾 +598", "🇪🇨 +593", "🇻🇪 +58", "🇵🇾 +595", "🇧🇴 +591",
                "🇬🇾 +592", "🇸🇷 +597", "🇬🇫 +594", "🇫🇰 +500",
            
                // Oceania (Complete)
                "🇦🇺 +61", "🇳🇿 +64", "🇫🇯 +679", "🇵🇬 +675", "🇼🇸 +685",
                "🇸🇧 +677", "🇻🇺 +678", "🇳🇨 +687", "🇵🇫 +689", "🇹🇴 +676",
                "🇰🇮 +686", "🇲🇭 +692", "🇳🇷 +674", 
                "🇹🇻 +688", "🇳🇺 +683", "🇨🇰 +682", "🇹🇰 +690", "🇼🇫 +681",
            
                // Middle East (Complete)
                "🇵🇸 +970", 
        };

        public static Dictionary<string, string> COUNTRY_CODE_TO_NAME = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            // Africa (Complete)
            { "+27", "South Africa" }, { "+234", "Nigeria" }, { "+254", "Kenya" }, { "+233", "Ghana" }, { "+255", "Tanzania" },
            { "+256", "Uganda" }, { "+263", "Zimbabwe" }, { "+265", "Malawi" }, { "+267", "Botswana" }, { "+264", "Namibia" },
            { "+20", "Egypt" }, { "+251", "Ethiopia" }, { "+237", "Cameroon" }, { "+249", "Sudan" }, { "+221", "Senegal" },
            { "+223", "Mali" }, { "+225", "Ivory Coast" }, { "+243", "DR Congo" }, { "+250", "Rwanda" }, { "+268", "Eswatini" },
            { "+266", "Lesotho" }, { "+216", "Tunisia" }, { "+212", "Morocco" }, { "+213", "Algeria" }, { "+218", "Libya" },
            { "+257", "Burundi" }, { "+238", "Cape Verde" }, { "+235", "Chad" }, { "+253", "Djibouti" }, { "+240", "Equatorial Guinea" },
            { "+291", "Eritrea" }, { "+241", "Gabon" }, { "+220", "Gambia" }, { "+224", "Guinea" }, { "+245", "Guinea-Bissau" },
            { "+222", "Mauritania" }, { "+230", "Mauritius" }, { "+258", "Mozambique" }, { "+227", "Niger" }, { "+232", "Sierra Leone" },
            { "+252", "Somalia" }, { "+211", "South Sudan" }, { "+228", "Togo" }, { "+260", "Zambia" }, { "+236", "Central African Republic" },
            { "+242", "Congo" }, { "+269", "Comoros" }, { "+248", "Seychelles" }, { "+239", "Sao Tome and Principe" }, { "+290", "Saint Helena" },
            
            // Europe (Complete)
            { "+44", "United Kingdom" }, { "+49", "Germany" }, { "+33", "France" }, { "+39", "Italy" }, { "+34", "Spain" },
            { "+31", "Netherlands" }, { "+32", "Belgium" }, { "+46", "Sweden" }, { "+47", "Norway" }, { "+358", "Finland" },
            { "+41", "Switzerland" }, { "+43", "Austria" }, { "+7", "Russia" }, { "+351", "Portugal" }, { "+30", "Greece" },
            { "+353", "Ireland" }, { "+48", "Poland" }, { "+420", "Czech Republic" }, { "+421", "Slovakia" }, { "+36", "Hungary" },
            { "+40", "Romania" }, { "+45", "Denmark" }, { "+359", "Bulgaria" }, { "+385", "Croatia" }, { "+370", "Lithuania" },
            { "+371", "Latvia" }, { "+372", "Estonia" }, { "+386", "Slovenia" }, { "+356", "Malta" }, { "+357", "Cyprus" },
            { "+352", "Luxembourg" }, { "+354", "Iceland" }, { "+376", "Andorra" }, { "+377", "Monaco" }, { "+379", "Vatican City" },
            
            // Asia (Complete)
            { "+91", "India" }, { "+86", "China" }, { "+81", "Japan" }, { "+82", "South Korea" }, { "+92", "Pakistan" },
            { "+880", "Bangladesh" }, { "+63", "Philippines" }, { "+66", "Thailand" }, { "+84", "Vietnam" }, { "+62", "Indonesia" },
            { "+60", "Malaysia" }, { "+65", "Singapore" }, { "+90", "Turkey" }, { "+966", "Saudi Arabia" }, { "+971", "UAE" },
            { "+972", "Israel" }, { "+962", "Jordan" }, { "+965", "Kuwait" }, { "+961", "Lebanon" },
            { "+968", "Oman" }, { "+973", "Bahrain" }, { "+967", "Yemen" }, { "+98", "Iran" }, { "+964", "Iraq" },
            { "+963", "Syria" }, { "+976", "Mongolia" }, { "+977", "Nepal" }, { "+94", "Sri Lanka" }, { "+95", "Myanmar" },
            { "+855", "Cambodia" }, { "+856", "Laos" }, { "+975", "Bhutan" }, { "+960", "Maldives" }, { "+673", "Brunei" },
            { "+670", "Timor-Leste" }, { "+680", "Palau" }, { "+691", "Micronesia" }, { "+93", "Afghanistan" },
            
            // North America & Caribbean (Complete)
            { "+1", "United States" }, { "+52", "Mexico" }, { "+53", "Cuba" }, { "+501", "Belize" },
            { "+502", "Guatemala" }, { "+503", "El Salvador" }, { "+504", "Honduras" }, { "+505", "Nicaragua" }, { "+506", "Costa Rica" },
            { "+507", "Panama" }, { "+509", "Haiti" }, { "+590", "Guadeloupe" }, { "+1242", "Bahamas" }, { "+1246", "Barbados" },
            { "+1264", "Anguilla" }, { "+1268", "Antigua and Barbuda" }, { "+1284", "British Virgin Islands" }, { "+1340", "US Virgin Islands" },
            { "+1441", "Bermuda" }, { "+1473", "Grenada" }, { "+1649", "Turks and Caicos" }, { "+1664", "Montserrat" }, { "+1671", "Guam" },
            { "+1684", "American Samoa" }, { "+1758", "St. Lucia" }, { "+1767", "Dominica" }, { "+1784", "St. Vincent" }, { "+1809", "Dominican Republic" },
            { "+1868", "Trinidad and Tobago" }, { "+1876", "Jamaica" }, { "+1939", "Puerto Rico" },
            
            // South America (Complete)
            { "+55", "Brazil" }, { "+54", "Argentina" }, { "+56", "Chile" }, { "+57", "Colombia" }, { "+51", "Peru" },
            { "+598", "Uruguay" }, { "+593", "Ecuador" }, { "+58", "Venezuela" }, { "+595", "Paraguay" }, { "+591", "Bolivia" },
            { "+592", "Guyana" }, { "+597", "Suriname" }, { "+594", "French Guiana" }, { "+500", "Falkland Islands" },
            
            // Oceania (Complete)
            { "+61", "Australia" }, { "+64", "New Zealand" }, { "+679", "Fiji" }, { "+675", "Papua New Guinea" }, { "+685", "Samoa" },
            { "+677", "Solomon Islands" }, { "+678", "Vanuatu" }, { "+687", "New Caledonia" }, { "+689", "French Polynesia" }, { "+676", "Tonga" },
            { "+686", "Kiribati" }, { "+692", "Marshall Islands" }, { "+674", "Nauru" }, { "+683", "Niue" }, { "+682", "Cook Islands" },
            { "+690", "Tokelau" }, { "+681", "Wallis and Futuna" },
            
            // Middle East (Complete)
            { "+970", "Palestine" }, { "+974", "Qatar" }
        };

        public static readonly Dictionary<string, (string Name, string FlagCode)> COUNTRY_CODE_FLAG_NAME = new()
        {
            { "+1", ("United States", "us") },
            { "+7", ("Russia", "ru") },
            { "+20", ("Egypt", "eg") },
            { "+27", ("South Africa", "za") },
            { "+30", ("Greece", "gr") },
            { "+31", ("Netherlands", "nl") },
            { "+32", ("Belgium", "be") },
            { "+33", ("France", "fr") },
            { "+34", ("Spain", "es") },
            { "+36", ("Hungary", "hu") },
            { "+39", ("Italy", "it") },
            { "+40", ("Romania", "ro") },
            { "+41", ("Switzerland", "ch") },
            { "+43", ("Austria", "at") },
            { "+44", ("United Kingdom", "gb") },
            { "+45", ("Denmark", "dk") },
            { "+46", ("Sweden", "se") },
            { "+47", ("Norway", "no") },
            { "+48", ("Poland", "pl") },
            { "+49", ("Germany", "de") },
            { "+51", ("Peru", "pe") },
            { "+52", ("Mexico", "mx") },
            { "+53", ("Cuba", "cu") },
            { "+54", ("Argentina", "ar") },
            { "+55", ("Brazil", "br") },
            { "+56", ("Chile", "cl") },
            { "+57", ("Colombia", "co") },
            { "+58", ("Venezuela", "ve") },
            { "+60", ("Malaysia", "my") },
            { "+61", ("Australia", "au") },
            { "+62", ("Indonesia", "id") },
            { "+63", ("Philippines", "ph") },
            { "+64", ("New Zealand", "nz") },
            { "+65", ("Singapore", "sg") },
            { "+66", ("Thailand", "th") },
            { "+81", ("Japan", "jp") },
            { "+82", ("South Korea", "kr") },
            { "+84", ("Vietnam", "vn") },
            { "+86", ("China", "cn") },
            { "+90", ("Turkey", "tr") },
            { "+91", ("India", "in") },
            { "+92", ("Pakistan", "pk") },
            { "+93", ("Afghanistan", "af") },
            { "+94", ("Sri Lanka", "lk") },
            { "+95", ("Myanmar", "mm") },
            { "+98", ("Iran", "ir") },
            { "+211", ("South Sudan", "ss") },
            { "+212", ("Morocco", "ma") },
            { "+213", ("Algeria", "dz") },
            { "+216", ("Tunisia", "tn") },
            { "+218", ("Libya", "ly") },
            { "+220", ("Gambia", "gm") },
            { "+221", ("Senegal", "sn") },
            { "+222", ("Mauritania", "mr") },
            { "+223", ("Mali", "ml") },
            { "+224", ("Guinea", "gn") },
            { "+225", ("Ivory Coast", "ci") },
            { "+226", ("Burkina Faso", "bf") },
            { "+227", ("Niger", "ne") },
            { "+228", ("Togo", "tg") },
            { "+229", ("Benin", "bj") },
            { "+230", ("Mauritius", "mu") },
            { "+231", ("Liberia", "lr") },
            { "+232", ("Sierra Leone", "sl") },
            { "+233", ("Ghana", "gh") },
            { "+234", ("Nigeria", "ng") },
            { "+235", ("Chad", "td") },
            { "+236", ("Central African Republic", "cf") },
            { "+237", ("Cameroon", "cm") },
            { "+238", ("Cape Verde", "cv") },
            { "+239", ("Sao Tome and Principe", "st") },
            { "+240", ("Equatorial Guinea", "gq") },
            { "+241", ("Gabon", "ga") },
            { "+242", ("Republic of the Congo", "cg") },
            { "+243", ("Democratic Republic of the Congo", "cd") },
            { "+244", ("Angola", "ao") },
            { "+245", ("Guinea-Bissau", "gw") },
            { "+246", ("Diego Garcia", "io") },
            { "+248", ("Seychelles", "sc") },
            { "+249", ("Sudan", "sd") },
            { "+250", ("Rwanda", "rw") },
            { "+251", ("Ethiopia", "et") },
            { "+252", ("Somalia", "so") },
            { "+253", ("Djibouti", "dj") },
            { "+254", ("Kenya", "ke") },
            { "+255", ("Tanzania", "tz") },
            { "+256", ("Uganda", "ug") },
            { "+257", ("Burundi", "bi") },
            { "+258", ("Mozambique", "mz") },
            { "+260", ("Zambia", "zm") },
            { "+261", ("Madagascar", "mg") },
            { "+262", ("Réunion", "re") },
            { "+263", ("Zimbabwe", "zw") },
            { "+264", ("Namibia", "na") },
            { "+265", ("Malawi", "mw") },
            { "+266", ("Lesotho", "ls") },
            { "+267", ("Botswana", "bw") },
            { "+268", ("Eswatini", "sz") },
            { "+269", ("Comoros", "km") },
            { "+290", ("Saint Helena", "sh") },
            { "+291", ("Eritrea", "er") },
            { "+297", ("Aruba", "aw") },
            { "+298", ("Faroe Islands", "fo") },
            { "+299", ("Greenland", "gl") },
            { "+350", ("Gibraltar", "gi") },
            { "+351", ("Portugal", "pt") },
            { "+352", ("Luxembourg", "lu") },
            { "+353", ("Ireland", "ie") },
            { "+354", ("Iceland", "is") },
            { "+355", ("Albania", "al") },
            { "+356", ("Malta", "mt") },
            { "+357", ("Cyprus", "cy") },
            { "+358", ("Finland", "fi") },
            { "+359", ("Bulgaria", "bg") },
            { "+370", ("Lithuania", "lt") },
            { "+371", ("Latvia", "lv") },
            { "+372", ("Estonia", "ee") },
            { "+373", ("Moldova", "md") },
            { "+374", ("Armenia", "am") },
            { "+375", ("Belarus", "by") },
            { "+376", ("Andorra", "ad") },
            { "+377", ("Monaco", "mc") },
            { "+378", ("San Marino", "sm") },
            { "+379", ("Vatican City", "va") },
            { "+380", ("Ukraine", "ua") },
            { "+381", ("Serbia", "rs") },
            { "+382", ("Montenegro", "me") },
            { "+383", ("Kosovo", "xk") },
            { "+385", ("Croatia", "hr") },
            { "+386", ("Slovenia", "si") },
            { "+387", ("Bosnia and Herzegovina", "ba") },
            { "+389", ("North Macedonia", "mk") },
            { "+420", ("Czech Republic", "cz") },
            { "+421", ("Slovakia", "sk") },
            { "+423", ("Liechtenstein", "li") },
            { "+500", ("Falkland Islands", "fk") },
            { "+501", ("Belize", "bz") },
            { "+502", ("Guatemala", "gt") },
            { "+503", ("El Salvador", "sv") },
            { "+504", ("Honduras", "hn") },
            { "+505", ("Nicaragua", "ni") },
            { "+506", ("Costa Rica", "cr") },
            { "+507", ("Panama", "pa") },
            { "+509", ("Haiti", "ht") },
            { "+590", ("Guadeloupe", "gp") },
            { "+591", ("Bolivia", "bo") },
            { "+592", ("Guyana", "gy") },
            { "+593", ("Ecuador", "ec") },
            { "+594", ("French Guiana", "gf") },
            { "+595", ("Paraguay", "py") },
            { "+597", ("Suriname", "sr") },
            { "+598", ("Uruguay", "uy") },
            { "+599", ("Curaçao", "cw") },
            { "+670", ("Timor-Leste", "tl") },
            { "+672", ("Norfolk Island", "nf") },
            { "+673", ("Brunei", "bn") },
            { "+674", ("Nauru", "nr") },
            { "+675", ("Papua New Guinea", "pg") },
            { "+676", ("Tonga", "to") },
            { "+677", ("Solomon Islands", "sb") },
            { "+678", ("Vanuatu", "vu") },
            { "+679", ("Fiji", "fj") },
            { "+680", ("Palau", "pw") },
            { "+681", ("Wallis and Futuna", "wf") },
            { "+682", ("Cook Islands", "ck") },
            { "+683", ("Niue", "nu") },
            { "+685", ("Samoa", "ws") },
            { "+686", ("Kiribati", "ki") },
            { "+687", ("New Caledonia", "nc") },
            { "+688", ("Tuvalu", "tv") },
            { "+689", ("French Polynesia", "pf") },
            { "+690", ("Tokelau", "tk") },
            { "+691", ("Micronesia", "fm") },
            { "+692", ("Marshall Islands", "mh") },
            { "+852", ("Hong Kong", "hk") },
            { "+855", ("Cambodia", "kh") },
            { "+856", ("Laos", "la") },
            { "+880", ("Bangladesh", "bd") },
            { "+886", ("Taiwan", "tw") },
            { "+960", ("Maldives", "mv") },
            { "+961", ("Lebanon", "lb") },
            { "+962", ("Jordan", "jo") },
            { "+963", ("Syria", "sy") },
            { "+964", ("Iraq", "iq") },
            { "+965", ("Kuwait", "kw") },
            { "+966", ("Saudi Arabia", "sa") },
            { "+967", ("Yemen", "ye") },
            { "+968", ("Oman", "om") },
            { "+970", ("Palestine", "ps") },
            { "+971", ("United Arab Emirates", "ae") },
            { "+972", ("Israel", "il") },
            { "+973", ("Bahrain", "bh") },
            { "+974", ("Qatar", "qa") },
            { "+975", ("Bhutan", "bt") },
            { "+976", ("Mongolia", "mn") },
            { "+977", ("Nepal", "np") }
        };

        public static string GetCountryNameFromCode(string code)
        {
            return COUNTRY_CODE_FLAG_NAME.TryGetValue(code, out var val) ? val.Name : "Unknown";
        }

        public static string GetCountryFlagCodeFromCode(string code)
        {
            return COUNTRY_CODE_FLAG_NAME.TryGetValue(code, out var val) ? val.FlagCode : "un";
        }

        public class SubscriptionPricing
        {
            private static readonly Dictionary<string, string> CountryCodeToPrice = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                // United States and Canada
                {"+1", "$4.99"}, // US
                {"+1242", "$4.99"}, // Bahamas
                {"+1246", "$5.99"}, // Barbados
                {"+1264", "$4.99"}, // Anguilla
                {"+1268", "$4.99"}, // Antigua and Barbuda
                {"+1284", "$4.99"}, // British Virgin Islands
                {"+1340", "$4.99"}, // US Virgin Islands
                {"+1441", "$4.99"}, // Bermuda
                {"+1473", "$4.99"}, // Grenada
                {"+1649", "$4.99"}, // Turks and Caicos
                {"+1664", "$4.99"}, // Montserrat
                {"+1671", "$4.99"}, // Guam
                {"+1684", "$4.99"}, // American Samoa
                {"+1758", "$4.99"}, // St. Lucia
                {"+1767", "$4.99"}, // Dominica
                {"+1784", "$4.99"}, // St. Vincent
                {"+1809", "$4.99"}, // Dominican Republic
                {"+1868", "$4.99"}, // Trinidad and Tobago
                {"+1876", "$4.99"}, // Jamaica
                {"+1939", "$4.99"}, // Puerto Rico
            
                // Africa, Middle East, and India
                {"+20", "E£249.99"}, // Egypt
                {"+27", "R95.00"}, // South Africa
                {"+91", "₹499.00"}, // India
                {"+234", "₦7,900.00"}, // Nigeria
                {"+256", "$5.99"}, // Uganda
                {"+233", "$5.99"}, // Ghana
                {"+212", "$4.99"}, // Morocco
                {"+213", "$4.99"}, // Algeria
                {"+216", "$4.99"}, // Tunisia
                {"+218", "$4.99"}, // Libya
                {"+220", "$4.99"}, // Gambia
                {"+221", "$5.99"}, // Senegal
                {"+222", "$4.99"}, // Mauritania
                {"+223", "$4.99"}, // Mali
                {"+224", "$4.99"}, // Guinea
                {"+225", "$5.99"}, // Côte d'Ivoire
                {"+226", "$4.99"}, // Burkina Faso
                {"+227", "$4.99"}, // Niger
                {"+228", "$4.99"}, // Togo
                {"+229", "$4.99"}, // Benin
                {"+230", "$4.99"}, // Mauritius
                {"+231", "$4.99"}, // Liberia
                {"+232", "$4.99"}, // Sierra Leone
                {"+235", "$4.99"}, // Chad
                {"+236", "$4.99"}, // Central African Republic
                {"+237", "$5.99"}, // Cameroon
                {"+238", "$4.99"}, // Cape Verde
                {"+239", "$4.99"}, // Sao Tome and Principe
                {"+240", "$4.99"}, // Equatorial Guinea
                {"+241", "$4.99"}, // Gabon
                {"+242", "$4.99"}, // Congo
                {"+243", "$4.99"}, // DR Congo
                {"+244", "$4.99"}, // Angola
                {"+245", "$4.99"}, // Guinea-Bissau
                {"+246", "$4.99"}, // Diego Garcia
                {"+248", "$4.99"}, // Seychelles
                {"+249", "$4.99"}, // Sudan
                {"+250", "$4.99"}, // Rwanda
                {"+251", "$4.99"}, // Ethiopia
                {"+252", "$4.99"}, // Somalia
                {"+253", "$4.99"}, // Djibouti
                {"+255", "TZS 14,900.00"}, // Tanzania
                {"+257", "$4.99"}, // Burundi
                {"+258", "$4.99"}, // Mozambique
                {"+260", "$5.99"}, // Zambia
                {"+261", "$4.99"}, // Madagascar
                {"+262", "$4.99"}, // Réunion
                {"+263", "$5.99"}, // Zimbabwe
                {"+264", "$4.99"}, // Namibia
                {"+265", "$4.99"}, // Malawi
                {"+266", "$4.99"}, // Lesotho
                {"+267", "$4.99"}, // Botswana
                {"+268", "$4.99"}, // Eswatini
                {"+269", "$4.99"}, // Comoros
                {"+290", "$4.99"}, // Saint Helena
                {"+291", "$4.99"}, // Eritrea
                {"+297", "$4.99"}, // Aruba
                {"+298", "$4.99"}, // Faroe Islands
                {"+299", "$4.99"}, // Greenland
            
                // Europe
                {"+30", "€5.99"}, // Greece
                {"+31", "€5.99"}, // Netherlands
                {"+32", "€5.99"}, // Belgium
                {"+33", "€5.99"}, // France
                {"+34", "€5.99"}, // Spain
                {"+36", "Ft 1,990.00"}, // Hungary
                {"+39", "€5.99"}, // Italy
                {"+40", "lei 29.99"}, // Romania
                {"+41", "CHF 5.00"}, // Switzerland
                {"+43", "€5.99"}, // Austria
                {"+44", "£4.99"}, // UK
                {"+45", "kr 39.00"}, // Denmark
                {"+46", "kr 69.00"}, // Sweden
                {"+47", "kr 59.00"}, // Norway
                {"+48", "zł 29.99"}, // Poland
                {"+49", "€5.99"}, // Germany
            
                // Asia Pacific
                {"+60", "RM 22.90"}, // Malaysia
                {"+61", "$7.99"}, // Australia
                {"+62", "Rp 89,000.00"}, // Indonesia
                {"+63", "₱299.00"}, // Philippines
                {"+64", "$9.99"}, // New Zealand
                {"+65", "$6.98"}, // Singapore
                {"+66", "฿199.00"}, // Thailand
                {"+81", "¥800.00"}, // Japan
                {"+82", "₩6,600.00"}, // South Korea
                {"+84", "₫129,000.00"}, // Vietnam
                {"+86", "¥38.00"}, // China
                {"+852", "$38.00"}, // Hong Kong
                {"+853", "$4.99"}, // Macau
                {"+886", "$150.00"}, // Taiwan
            
                // Latin America
                {"+52", "$99.00"}, // Mexico
                {"+53", "$4.99"}, // Cuba
                {"+54", "$4.99"}, // Argentina
                {"+55", "R$29.90"}, // Brazil
                {"+56", "$5,990.00"}, // Chile
                {"+57", "$24,900.00"}, // Colombia
                {"+58", "$4.99"}, // Venezuela
                {"+501", "$4.99"}, // Belize
                {"+502", "$4.99"}, // Guatemala
                {"+503", "$4.99"}, // El Salvador
                {"+504", "$4.99"}, // Honduras
                {"+505", "$4.99"}, // Nicaragua
                {"+506", "$4.99"}, // Costa Rica
                {"+507", "$4.99"}, // Panama
                {"+508", "$4.99"}, // St. Pierre & Miquelon
                {"+509", "$4.99"}, // Haiti
                {"+590", "$4.99"}, // Guadeloupe
                {"+591", "$4.99"}, // Bolivia
                {"+592", "$4.99"}, // Guyana
                {"+593", "$4.99"}, // Ecuador
                {"+594", "$4.99"}, // French Guiana
                {"+595", "$4.99"}, // Paraguay
                {"+596", "$4.99"}, // Martinique
                {"+597", "$4.99"}, // Suriname
                {"+598", "$4.99"}, // Uruguay
            
                // Default fallback
                {"default", "$4.99"}
            };

            public static string GetSubscriptionPrice(string countryCode)
            {
                if (string.IsNullOrEmpty(countryCode))
                    return CountryCodeToPrice["default"];

                // Handle country codes with varying lengths
                var normalizedCode = countryCode.Trim();

                // Check exact match first
                if (CountryCodeToPrice.ContainsKey(normalizedCode))
                    return CountryCodeToPrice[normalizedCode];

                // Check for partial matches (e.g., +1 for US/Canada)
                if (normalizedCode.Length > 2)
                {
                    var shorterCode = normalizedCode.Substring(0, 2);
                    if (CountryCodeToPrice.ContainsKey(shorterCode))
                        return CountryCodeToPrice[shorterCode];
                }

                return CountryCodeToPrice["default"];
            }

            public static string GetSubscriptionPriceWithCurrency(string countryCode)
            {
                var price = GetSubscriptionPrice(countryCode);
                return $"{price} / month";
            }

            public static string GetCurrencySymbol(string localizedPrice)
            {
                // This extracts the currency symbol from price strings like "$4.99" or "€4.99"
                if (string.IsNullOrEmpty(localizedPrice))
                    return null;

                return localizedPrice.FirstOrDefault(char.IsSymbol).ToString() ??
                       localizedPrice.Substring(0, 1);
            }

            public static async Task<double> GetConvertedPriceForOvulaeZarOrUsd(string localizedPrice)
            {
                if (string.IsNullOrEmpty(localizedPrice))
                    return 0;

                var symbol = GetCurrencySymbol(localizedPrice);
                var numericPart = new string(localizedPrice.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

                if (!double.TryParse(numericPart, NumberStyles.Any, CultureInfo.InvariantCulture, out var amount))
                    return 0;

                if (symbol == "R")
                    return amount;

                var currencyCode = symbol switch
                {
                    "$" => "USD",
                    "€" => "EUR",
                    "£" => "GBP",
                    "R" => "ZAR",
                    _ => "USD"
                };

                if (currencyCode == "USD")
                    return Math.Round(amount, 2);

                var rate = await PricingHelperFunctions.GetExchangeRateAsync(currencyCode, "USD");
                if (rate == null)
                    return 5.99;

                var converted = amount * (double)rate;
                return Math.Round(converted, 2);
            }

            public static async Task<double> GetConvertedPriceForOvulaeZarOrUsdFromCountryCode(string countryCode)
            {
                string localizedPrice = GetSubscriptionPrice(countryCode);
                return await GetConvertedPriceForOvulaeZarOrUsd(localizedPrice);
            }
        }
    }
}

