namespace Coffee_Ecommerce.WebApp.Services
{
    public static class CpfGenerator
    {
        public static string GenerateCpf()
        {
            int randomNumber = new Random().Next(1000000, 1000000000);
            string cpfBase = randomNumber.ToString();
            int generatedDigits = cpfBase.Length;

            for (int i = 0; i < 9 - generatedDigits; i++)
            {
                cpfBase = cpfBase.Insert(0, "0");
            }

            return $"{cpfBase}{CalculateVD(cpfBase)}";
        }

        private static string CalculateVD(string cpfBase)
        {
            char[] splitNumber = cpfBase.ToArray();
            int[] digits = splitNumber.Select(c => int.Parse(c.ToString())).ToArray();

            int firstDigit = (digits[0] * 10 + digits[1] * 9 + digits[2] * 8 + digits[3] * 7 + digits[4] * 6 + digits[5] * 5 + digits[6] * 4 + digits[7] * 3 + digits[8] * 2) * 10 % 11;

            firstDigit = firstDigit == 10 ? 0 : firstDigit;

            int secondDigit = (digits[0] * 11 + digits[1] * 10 + digits[2] * 9 + digits[3] * 8 + digits[4] * 7 + digits[5] * 6 + digits[6] * 5 + digits[7] * 4 + digits[8] * 3 + firstDigit * 2) * 10 % 11;

            secondDigit = secondDigit == 10 ? 0 : secondDigit;

            return $"{firstDigit}{secondDigit}";
        }
    }
}
