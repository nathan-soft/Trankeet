﻿using System.Diagnostics.Metrics;

namespace TrankeetWeb.Data
{
    public static class CountryData
    {
        public static List<Country> GetAllCountries()
        {
            return new List<Country>
            {
                new Country("Afghanistan", "+93", "AF"),
                new Country("Albania", "+355", "AL"),
                new Country("Algeria", "+213", "DZ"),
                new Country("Andorra", "+376", "AD"),
                new Country("Angola", "+244", "AO"),
                new Country("Antigua and Barbuda", "+1", "AG"),
                new Country("Argentina", "+54", "AR"),
                new Country("Armenia", "+374", "AM"),
                new Country("Australia", "+61", "AU"),
                new Country("Austria", "+43", "AT"),
                new Country("Azerbaijan", "+994", "AZ"),
                new Country("Bahamas", "+1", "BS"),
                new Country("Bahrain", "+973", "BH"),
                new Country("Bangladesh", "+880", "BD"),
                new Country("Barbados", "+1", "BB"),
                new Country("Belarus", "+375", "BY"),
                new Country("Belgium", "+32", "BE"),
                new Country("Belize", "+501", "BZ"),
                new Country("Benin", "+229", "BJ"),
                new Country("Bhutan", "+975", "BT"),
                new Country("Bolivia", "+591", "BO"),
                new Country("Bosnia and Herzegovina", "+387", "BA"),
                new Country("Botswana", "+267", "BW"),
                new Country("Brazil", "+55", "BR"),
                new Country("Brunei", "+673", "BN"),
                new Country("Bulgaria", "+359", "BG"),
                new Country("Burkina Faso", "+226", "BF"),
                new Country("Burundi", "+257", "BI"),
                new Country("Cabo Verde", "+238", "CV"),
                new Country("Cambodia", "+855", "KH"),
                new Country("Cameroon", "+237", "CM"),
                new Country("Canada", "+1", "CA"),
                new Country("Central African Republic", "+236", "CF"),
                new Country("Chad", "+235", "TD"),
                new Country("Chile", "+56", "CL"),
                new Country("China", "+86", "CN"),
                new Country("Colombia", "+57", "CO"),
                new Country("Comoros", "+269", "KM"),
                new Country("Congo", "+242", "CG"),
                new Country("Congo (Democratic Republic of the)", "+243", "CD"),
                new Country("Costa Rica", "+506", "CR"),
                new Country("Croatia", "+385", "HR"),
                new Country("Cuba", "+53", "CU"),
                new Country("Cyprus", "+357", "CY"),
                new Country("Czech Republic", "+420", "CZ"),
                new Country("Denmark", "+45", "DK"),
                new Country("Djibouti", "+253", "DJ"),
                new Country("Dominica", "+1", "DM"),
                new Country("Dominican Republic", "+1", "DO"),
                new Country("Ecuador", "+593", "EC"),
                new Country("Egypt", "+20", "EG"),
                new Country("El Salvador", "+503", "SV"),
                new Country("Equatorial Guinea", "+240", "GQ"),
                new Country("Eritrea", "+291", "ER"),
                new Country("Estonia", "+372", "EE"),
                new Country("Eswatini", "+268", "SZ"),
                new Country("Ethiopia", "+251", "ET"),
                new Country("Fiji", "+679", "FJ"),
                new Country("Finland", "+358", "FI"),
                new Country("France", "+33", "FR"),
                new Country("Gabon", "+241", "GA"),
                new Country("Gambia", "+220", "GM"),
                new Country("Georgia", "+995", "GE"),
                new Country("Germany", "+49", "DE"),
                new Country("Ghana", "+233", "GH"),
                new Country("Greece", "+30", "GR"),
                new Country("Grenada", "+1", "GD"),
                new Country("Guatemala", "+502", "GT"),
                new Country("Guinea", "+224", "GN"),
                new Country("Guinea-Bissau", "+245", "GW"),
                new Country("Guyana", "+592", "GY"),
                new Country("Haiti", "+509", "HT"),
                new Country("Honduras", "+504", "HN"),
                new Country("Hungary", "+36", "HU"),
                new Country("Iceland", "+354", "IS"),
                new Country("India", "+91", "IN"),
                new Country("Indonesia", "+62", "ID"),
                new Country("Iran", "+98", "IR"),
                new Country("Iraq", "+964", "IQ"),
                new Country("Ireland", "+353", "IE"),
                new Country("Israel", "+972", "IL"),
                new Country("Italy", "+39", "IT"),
                new Country("Jamaica", "+1", "JM"),
                new Country("Japan", "+81", "JP"),
                new Country("Jordan", "+962", "JO"),
                new Country("Kazakhstan", "+7", "KZ"),
                new Country("Kenya", "+254", "KE"),
                new Country("Kiribati", "+686", "KI"),
                new Country("Korea (North)", "+850", "KP"),
                new Country("Korea (South)", "+82", "KR"),
                new Country("Kuwait", "+965", "KW"),
                new Country("Kyrgyzstan", "+996", "KG"),
                new Country("Laos", "+856", "LA"),
                new Country("Latvia", "+371", "LV"),
                new Country("Lebanon", "+961", "LB"),
                new Country("Lesotho", "+266", "LS"),
                new Country("Liberia", "+231", "LR"),
                new Country("Libya", "+218", "LY"),
                new Country("Liechtenstein", "+423", "LI"),
                new Country("Lithuania", "+370", "LT"),
                new Country("Luxembourg", "+352", "LU"),
                new Country("Madagascar", "+261", "MG"),
                new Country("Malawi", "+265", "MW"),
                new Country("Malaysia", "+60", "MY"),
                new Country("Maldives", "+960", "MV"),
                new Country("Mali", "+223", "ML"),
                new Country("Malta", "+356", "MT"),
                new Country("Marshall Islands", "+692", "MH"),
                new Country("Mauritania", "+222", "MR"),
                new Country("Mauritius", "+230", "MU"),
                new Country("Mexico", "+52", "MX"),
                new Country("Micronesia", "+691", "FM"),
                new Country("Moldova", "+373", "MD"),
                new Country("Monaco", "+377", "MC"),
                new Country("Mongolia", "+976", "MN"),
                new Country("Montenegro", "+382", "ME"),
                new Country("Morocco", "+212", "MA"),
                new Country("Mozambique", "+258", "MZ"),
                new Country("Myanmar", "+95", "MM"),
                new Country("Namibia", "+264", "NA"),
                new Country("Nauru", "+674", "NR"),
                new Country("Nepal", "+977", "NP"),
                new Country("Netherlands", "+31", "NL"),
                new Country("New Zealand", "+64", "NZ"),
                new Country("Nicaragua", "+505", "NI"),
                new Country("Niger", "+227", "NE"),
                new Country("Nigeria", "+234", "NG"),
                new Country("North Macedonia", "+389", "MK"),
                new Country("Norway", "+47", "NO"),
                new Country("Oman", "+968", "OM"),
                new Country("Pakistan", "+92", "PK"),
                new Country("Palau", "+680", "PW"),
                new Country("Palestine", "+970", "PS"),
                new Country("Panama", "+507", "PA"),
                new Country("Papua New Guinea", "+675", "PG"),
                new Country("Paraguay", "+595", "PY"),
                new Country("Peru", "+51", "PE"),
                new Country("Philippines", "+63", "PH"),
                new Country("Poland", "+48", "PL"),
                new Country("Portugal", "+351", "PT"),
                new Country("Qatar", "+974", "QA"),
                new Country("Romania", "+40", "RO"),
                new Country("Russia", "+7", "RU"),
                new Country("Rwanda", "+250", "RW"),
                new Country("Saint Kitts and Nevis", "+1", "KN"),
                new Country("Saint Lucia", "+1", "LC"),
                new Country("Saint Vincent and the Grenadines", "+1", "VC"),
                new Country("Samoa", "+685", "WS"),
                new Country("San Marino", "+378", "SM"),
                new Country("Sao Tome and Principe", "+239", "ST"),
                new Country("Saudi Arabia", "+966", "SA"),
                new Country("Senegal", "+221", "SN"),
                new Country("Serbia", "+381", "RS"),
                new Country("Seychelles", "+248", "SC"),
                new Country("Sierra Leone", "+232", "SL"),
                new Country("Singapore", "+65", "SG"),
                new Country("Slovakia", "+421", "SK"),
                new Country("Slovenia", "+386", "SI"),
                new Country("Solomon Islands", "+677", "SB"),
                new Country("Somalia", "+252", "SO"),
                new Country("South Africa", "+27", "ZA"),
                new Country("South Sudan", "+211", "SS"),
                new Country("Spain", "+34", "ES"),
                new Country("Sri Lanka", "+94", "LK"),
                new Country("Sudan", "+249", "SD"),
                new Country("Suriname", "+597", "SR"),
                new Country("Sweden", "+46", "SE"),
                new Country("Switzerland", "+41", "CH"),
                new Country("Syria", "+963", "SY"),
                new Country("Taiwan", "+886", "TW"),
                new Country("Tajikistan", "+992", "TJ"),
                new Country("Tanzania", "+255", "TZ"),
                new Country("Thailand", "+66", "TH"),
                new Country("Timor-Leste", "+670", "TL"),
                new Country("Togo", "+228", "TG"),
                new Country("Tonga", "+676", "TO"),
                new Country("Trinidad and Tobago", "+1", "TT"),
                new Country("Tunisia", "+216", "TN"),
                new Country("Turkey", "+90", "TR"),
                new Country("Turkmenistan", "+993", "TM"),
                new Country("Tuvalu", "+688", "TV"),
                new Country("Uganda", "+256", "UG"),
                new Country("Ukraine", "+380", "UA"),
                new Country("United Arab Emirates", "+971", "AE"),
                new Country("United Kingdom", "+44", "GB"),
                new Country("United States of America", "+1", "US"),
                new Country("Uruguay", "+598", "UY"),
                new Country("Uzbekistan", "+998", "UZ"),
                new Country("Vanuatu", "+678", "VU"),
                new Country("Vatican City", "+379", "VA"),
                new Country("Venezuela", "+58", "VE"),
                new Country("Vietnam", "+84", "VN"),
                new Country("Yemen", "+967", "YE"),
                new Country("Zambia", "+260", "ZM"),
                new Country("Zimbabwe", "+263", "ZW")
            };
        }
    }


    public class Country
    {
        public string Name { get; set; }
        public string DialingCode { get; set; }
        public string Abbreviation { get; set; }

        public Country(string name, string dialingCode, string abbreviation)
        {
            Name = name;
            DialingCode = dialingCode;
            Abbreviation = abbreviation;
        }
    }
}
