namespace MZ.Dev.Talabat.API.Errors
{
    public class ApiValiadtionErrorRespose:ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }
        public ApiValiadtionErrorRespose() : base(400)
        {
            Errors =  new List<string>();
        }
    }
}
