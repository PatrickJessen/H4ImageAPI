namespace H4ImageAPI
{
    public class ImageToBase64
    {
        string[] images = { "messi.jpeg", "messi2.jpg", "messi3.png" };
        public string ToBase64()
        {
            Random random = new Random();
            string image = images[random.Next(images.Length)];
            byte[] imageArray = File.ReadAllBytes("Images/" + image);
            return Convert.ToBase64String(imageArray);
        }
    }
}
