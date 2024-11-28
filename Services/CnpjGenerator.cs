namespace Coffee_Ecommerce.WebApp.Services
{
    public static class CnpjGenerator
    {
        public static string GenerateCnpj()
        {
            // 00.000.000/6789-02
            // 10000000000
            // 1000000000000
            long randomNumber = new Random().NextInt64(10000000000, 1000000000000);
            string cnpjBase = randomNumber.ToString();
            int generatedDigits = cnpjBase.Length;

            for (int i = 0; i < 12 - generatedDigits; i++)
            {
                cnpjBase = cnpjBase.Insert(0, "0");
            }

            return $"{cnpjBase}{CalculateVD(cnpjBase)}";
        }

        private static string CalculateVD(string cnpjBase)
        {
            char[] splitNumber = cnpjBase.ToArray();
            int[] digits = splitNumber.Select(c => int.Parse(c.ToString())).ToArray();

            int firstDigit = (digits[0] * 5 + digits[1] * 4 + digits[2] * 3 + digits[3] * 2 + digits[4] * 9 + digits[5] * 8 + digits[6] * 7 + digits[7] * 6 + digits[8] * 5 + digits[9] * 4 + digits[10] * 3 + digits[11] * 2) % 11;

            firstDigit = firstDigit < 2 ? 0 : 11 - firstDigit;

            int secondDigit = (digits[0] * 6 + digits[1] * 5 + digits[2] * 4 + digits[3] * 3 + digits[4] * 2 + digits[5] * 9 + digits[6] * 8 + digits[7] * 7 + digits[8] * 6 + digits[9] * 5 + digits[10] * 4 + digits[11] * 3 + firstDigit * 2) % 11;

            secondDigit = secondDigit < 2 ? 0 : 11 - secondDigit;

            return $"{firstDigit}{secondDigit}";
        }
    }
}
