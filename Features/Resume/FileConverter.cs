namespace Coffee_Ecommerce.WebApp.Features.Resume
{
    public static class FileConverter
    {
        public static async Task<string> ConvertFileToStringAsync(Stream fileStream)
        {
            var converter = new StreamReader(fileStream);
            return await converter.ReadToEndAsync();
        }

        public static async Task<byte[]> ConvertFileToBytesAsync(Stream fileStream)
        {
            byte[] buffer = new byte[fileStream.Length - 1];
            await fileStream.ReadAsync(buffer);

            return buffer;
        }
    }
}
