using System.Collections.Generic;

namespace TailSpin.SpaceGame.Web.Services
{
    public static class MockPriceData
    {
        // Base prices per test per provider (in INR)
        // Format: TestName -> ProviderName -> Price
        public static readonly Dictionary<string, Dictionary<string, decimal>> BasePrices =
            new Dictionary<string, Dictionary<string, decimal>>
            {
                ["Complete Blood Count"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 199, ["PharmEasy"] = 219, ["Orange Health"] = 249, ["Apollo 24*7"] = 279
                },
                ["Lipid Profile"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 549, ["PharmEasy"] = 539, ["Orange Health"] = 599, ["Apollo 24*7"] = 649
                },
                ["Thyroid Stimulating Hormone"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 299, ["PharmEasy"] = 319, ["Orange Health"] = 349, ["Apollo 24*7"] = 399
                },
                ["Thyroid Panel"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 649, ["PharmEasy"] = 629, ["Orange Health"] = 699, ["Apollo 24*7"] = 749
                },
                ["Blood Sugar Fasting"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 79, ["PharmEasy"] = 89, ["Orange Health"] = 99, ["Apollo 24*7"] = 119
                },
                ["Blood Sugar Postprandial"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 79, ["PharmEasy"] = 89, ["Orange Health"] = 99, ["Apollo 24*7"] = 119
                },
                ["HbA1c"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 349, ["PharmEasy"] = 329, ["Orange Health"] = 399, ["Apollo 24*7"] = 449
                },
                ["Liver Function Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 449, ["PharmEasy"] = 469, ["Orange Health"] = 499, ["Apollo 24*7"] = 549
                },
                ["Kidney Function Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 449, ["PharmEasy"] = 479, ["Orange Health"] = 519, ["Apollo 24*7"] = 579
                },
                ["Vitamin D"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 899, ["PharmEasy"] = 849, ["Orange Health"] = 949, ["Apollo 24*7"] = 1099
                },
                ["Vitamin B12"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 649, ["PharmEasy"] = 629, ["Orange Health"] = 699, ["Apollo 24*7"] = 799
                },
                ["COVID-19 RT-PCR"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 499, ["Orange Health"] = 549, ["Apollo 24*7"] = 499
                },
                ["Dengue NS1 Antigen"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 549, ["PharmEasy"] = 579, ["Orange Health"] = 599, ["Apollo 24*7"] = 649
                },
                ["Urine Routine Examination"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["Iron Studies"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 449, ["PharmEasy"] = 429, ["Orange Health"] = 499, ["Apollo 24*7"] = 549
                },
                ["Calcium"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 149, ["PharmEasy"] = 159, ["Orange Health"] = 179, ["Apollo 24*7"] = 199
                },
                ["Serum Electrolytes"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 249, ["PharmEasy"] = 269, ["Orange Health"] = 299, ["Apollo 24*7"] = 349
                },
                ["C-Reactive Protein"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 349, ["PharmEasy"] = 369, ["Orange Health"] = 399, ["Apollo 24*7"] = 449
                },
                ["ESR"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 79, ["PharmEasy"] = 89, ["Orange Health"] = 99, ["Apollo 24*7"] = 119
                },
                ["Uric Acid"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 149, ["PharmEasy"] = 159, ["Orange Health"] = 179, ["Apollo 24*7"] = 199
                },
                ["Rheumatoid Factor"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 249, ["PharmEasy"] = 269, ["Orange Health"] = 299, ["Apollo 24*7"] = 349
                },
                ["ANA Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 699, ["PharmEasy"] = 729, ["Orange Health"] = 799, ["Apollo 24*7"] = 899
                },
                ["Hepatitis B Surface Antigen"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 249, ["PharmEasy"] = 269, ["Orange Health"] = 299, ["Apollo 24*7"] = 349
                },
                ["Hepatitis C Antibody"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 299, ["PharmEasy"] = 319, ["Orange Health"] = 349, ["Apollo 24*7"] = 399
                },
                ["HIV Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 299, ["PharmEasy"] = 319, ["Orange Health"] = 349, ["Apollo 24*7"] = 399
                },
                ["Malaria Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 199, ["PharmEasy"] = 219, ["Orange Health"] = 249, ["Apollo 24*7"] = 299
                },
                ["Typhoid Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 299, ["PharmEasy"] = 319, ["Orange Health"] = 349, ["Apollo 24*7"] = 399
                },
                ["Widal Test"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 149, ["PharmEasy"] = 169, ["Orange Health"] = 199, ["Apollo 24*7"] = 249
                },
                ["Stool Routine Examination"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["Semen Analysis"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 529, ["Orange Health"] = 599, ["Apollo 24*7"] = 649
                },
                ["Prolactin"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 349, ["PharmEasy"] = 369, ["Orange Health"] = 399, ["Apollo 24*7"] = 449
                },
                ["Testosterone"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 529, ["Orange Health"] = 579, ["Apollo 24*7"] = 649
                },
                ["FSH"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 349, ["PharmEasy"] = 369, ["Orange Health"] = 399, ["Apollo 24*7"] = 449
                },
                ["LH"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 349, ["PharmEasy"] = 369, ["Orange Health"] = 399, ["Apollo 24*7"] = 449
                },
                ["Estradiol"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 529, ["Orange Health"] = 579, ["Apollo 24*7"] = 649
                },
                ["Beta HCG"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 449, ["PharmEasy"] = 479, ["Orange Health"] = 529, ["Apollo 24*7"] = 599
                },
                ["PSA"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 599, ["PharmEasy"] = 629, ["Orange Health"] = 699, ["Apollo 24*7"] = 799
                },
                ["Cortisol"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 529, ["Orange Health"] = 579, ["Apollo 24*7"] = 649
                },
                ["Insulin Fasting"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 449, ["PharmEasy"] = 469, ["Orange Health"] = 519, ["Apollo 24*7"] = 599
                },
                ["Magnesium"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 199, ["PharmEasy"] = 219, ["Orange Health"] = 249, ["Apollo 24*7"] = 299
                },
                ["Phosphorus"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 149, ["PharmEasy"] = 169, ["Orange Health"] = 199, ["Apollo 24*7"] = 249
                },
                ["Total Protein"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 149, ["PharmEasy"] = 169, ["Orange Health"] = 199, ["Apollo 24*7"] = 249
                },
                ["Albumin"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["Blood Culture"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 799, ["PharmEasy"] = 849, ["Orange Health"] = 899, ["Apollo 24*7"] = 999
                },
                ["Urine Culture"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 499, ["PharmEasy"] = 529, ["Orange Health"] = 579, ["Apollo 24*7"] = 649
                },
                ["Throat Swab Culture"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 549, ["PharmEasy"] = 579, ["Orange Health"] = 629, ["Apollo 24*7"] = 699
                },
                ["Pap Smear"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 599, ["PharmEasy"] = 629, ["Orange Health"] = 699, ["Apollo 24*7"] = 799
                },
                ["Creatinine"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["Blood Urea Nitrogen"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["Bilirubin Total"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["SGPT ALT"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
                ["SGOT AST"] = new Dictionary<string, decimal>
                {
                    ["Tata 1mg"] = 99, ["PharmEasy"] = 109, ["Orange Health"] = 129, ["Apollo 24*7"] = 149
                },
            };

        // City-based price multipliers
        public static readonly Dictionary<string, decimal> CityMultipliers =
            new Dictionary<string, decimal>
            {
                ["mumbai"] = 1.10m,
                ["delhi"] = 1.08m,
                ["new delhi"] = 1.08m,
                ["bangalore"] = 1.05m,
                ["bengaluru"] = 1.05m,
                ["hyderabad"] = 1.00m,
                ["chennai"] = 1.02m,
                ["kolkata"] = 1.03m,
                ["pune"] = 1.04m,
                ["ahmedabad"] = 1.00m,
                ["jaipur"] = 0.97m,
                ["lucknow"] = 0.96m,
                ["bhopal"] = 0.95m,
                ["indore"] = 0.95m,
                ["nagpur"] = 0.96m,
                ["surat"] = 0.97m,
                ["coimbatore"] = 0.96m,
                ["kochi"] = 0.98m,
                ["chandigarh"] = 0.97m,
                ["gurgaon"] = 1.06m,
                ["gurugram"] = 1.06m,
                ["noida"] = 1.05m,
            };

        // Test aliases for fuzzy matching
        public static readonly Dictionary<string, List<string>> TestAliases =
            new Dictionary<string, List<string>>
            {
                ["Complete Blood Count"] = new List<string> { "cbc", "complete blood count", "blood count", "hemogram", "full blood count", "fbc" },
                ["Lipid Profile"] = new List<string> { "lipid", "lipid profile", "cholesterol", "lipid panel", "cholesterol test" },
                ["Thyroid Stimulating Hormone"] = new List<string> { "tsh", "thyroid stimulating hormone", "thyroid test" },
                ["Thyroid Panel"] = new List<string> { "thyroid panel", "thyroid profile", "t3 t4 tsh", "thyroid function" },
                ["Blood Sugar Fasting"] = new List<string> { "fasting blood sugar", "fbs", "blood glucose fasting", "fasting glucose" },
                ["Blood Sugar Postprandial"] = new List<string> { "pp blood sugar", "ppbs", "postprandial glucose", "blood sugar pp", "2 hour glucose" },
                ["HbA1c"] = new List<string> { "hba1c", "glycated hemoglobin", "a1c", "glycohemoglobin", "hb a1c" },
                ["Liver Function Test"] = new List<string> { "lft", "liver function", "liver panel", "liver test", "hepatic function" },
                ["Kidney Function Test"] = new List<string> { "kft", "kidney function", "renal function", "kidney test", "rft", "renal profile" },
                ["Vitamin D"] = new List<string> { "vitamin d", "vit d", "25-oh vitamin d", "vitamin d3", "25 hydroxyvitamin d" },
                ["Vitamin B12"] = new List<string> { "vitamin b12", "vit b12", "cobalamin", "b12", "cyanocobalamin" },
                ["COVID-19 RT-PCR"] = new List<string> { "covid", "covid-19", "coronavirus", "rt-pcr", "rtpcr", "covid pcr", "sars-cov-2" },
                ["Dengue NS1 Antigen"] = new List<string> { "dengue", "dengue ns1", "dengue antigen", "ns1 antigen" },
                ["Urine Routine Examination"] = new List<string> { "urine test", "urine routine", "urinalysis", "urine analysis", "ure", "urine re" },
                ["Iron Studies"] = new List<string> { "iron", "iron studies", "serum iron", "iron panel", "iron profile" },
                ["Calcium"] = new List<string> { "calcium", "serum calcium", "ca" },
                ["Serum Electrolytes"] = new List<string> { "electrolytes", "serum electrolytes", "na k cl", "sodium potassium" },
                ["C-Reactive Protein"] = new List<string> { "crp", "c-reactive protein", "c reactive protein" },
                ["ESR"] = new List<string> { "esr", "erythrocyte sedimentation rate", "sedimentation rate" },
                ["Uric Acid"] = new List<string> { "uric acid", "gout test", "serum uric acid" },
                ["Rheumatoid Factor"] = new List<string> { "rf", "rheumatoid factor", "ra factor", "rheumatoid arthritis test" },
                ["ANA Test"] = new List<string> { "ana", "antinuclear antibody", "ana test" },
                ["Hepatitis B Surface Antigen"] = new List<string> { "hbsag", "hepatitis b", "hbs ag", "hepatitis b surface antigen" },
                ["Hepatitis C Antibody"] = new List<string> { "hcv", "hepatitis c", "anti-hcv", "hepatitis c antibody" },
                ["HIV Test"] = new List<string> { "hiv", "hiv test", "aids test", "anti-hiv" },
                ["Malaria Test"] = new List<string> { "malaria", "malaria test", "malaria antigen" },
                ["Typhoid Test"] = new List<string> { "typhoid", "typhoid test", "salmonella" },
                ["Widal Test"] = new List<string> { "widal", "widal test" },
                ["Stool Routine Examination"] = new List<string> { "stool test", "stool routine", "stool analysis", "feces test" },
                ["Semen Analysis"] = new List<string> { "semen analysis", "sperm test", "semen test", "sperm count" },
                ["Prolactin"] = new List<string> { "prolactin", "prl" },
                ["Testosterone"] = new List<string> { "testosterone", "total testosterone", "serum testosterone" },
                ["FSH"] = new List<string> { "fsh", "follicle stimulating hormone" },
                ["LH"] = new List<string> { "lh", "luteinizing hormone", "luteinising hormone" },
                ["Estradiol"] = new List<string> { "estradiol", "oestradiol", "e2" },
                ["Beta HCG"] = new List<string> { "beta hcg", "bhcg", "pregnancy test", "hcg test", "beta human chorionic gonadotropin" },
                ["PSA"] = new List<string> { "psa", "prostate specific antigen", "prostate test" },
                ["Cortisol"] = new List<string> { "cortisol", "serum cortisol" },
                ["Insulin Fasting"] = new List<string> { "insulin", "fasting insulin", "serum insulin" },
                ["Magnesium"] = new List<string> { "magnesium", "serum magnesium", "mg" },
                ["Phosphorus"] = new List<string> { "phosphorus", "phosphate", "serum phosphorus" },
                ["Total Protein"] = new List<string> { "total protein", "serum protein", "protein test" },
                ["Albumin"] = new List<string> { "albumin", "serum albumin" },
                ["Blood Culture"] = new List<string> { "blood culture", "blood culture sensitivity" },
                ["Urine Culture"] = new List<string> { "urine culture", "urine c/s", "urine culture sensitivity" },
                ["Throat Swab Culture"] = new List<string> { "throat swab", "throat culture" },
                ["Pap Smear"] = new List<string> { "pap smear", "pap test", "cervical smear", "papanicolaou" },
                ["Creatinine"] = new List<string> { "creatinine", "serum creatinine" },
                ["Blood Urea Nitrogen"] = new List<string> { "bun", "blood urea", "blood urea nitrogen", "urea" },
                ["Bilirubin Total"] = new List<string> { "bilirubin", "total bilirubin", "serum bilirubin" },
                ["SGPT ALT"] = new List<string> { "sgpt", "alt", "alanine aminotransferase" },
                ["SGOT AST"] = new List<string> { "sgot", "ast", "aspartate aminotransferase" },
            };

        public static decimal GetCityMultiplier(string city)
        {
            if (string.IsNullOrWhiteSpace(city)) return 1.0m;
            var key = city.Trim().ToLower();
            return CityMultipliers.TryGetValue(key, out var multiplier) ? multiplier : 0.95m;
        }

        public static string ResolveTestName(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;
            var lower = input.Trim().ToLower();

            foreach (var alias in TestAliases)
            {
                if (alias.Value.Any(a => a.Contains(lower) || lower.Contains(a)))
                    return alias.Key;
            }

            // Exact canonical name match
            foreach (var test in BasePrices.Keys)
            {
                if (test.ToLower().Contains(lower) || lower.Contains(test.ToLower()))
                    return test;
            }

            return null;
        }
    }
}
