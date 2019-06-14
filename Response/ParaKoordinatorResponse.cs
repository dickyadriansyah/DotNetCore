using SupermarketAPI.Models;

namespace SupermarketAPI.Response
{
    public class ParaKoordinatorResponse : BaseResponse
    {
        public para_koordinator para_koor { get; set; }

        public ParaKoordinatorResponse(bool success, string message, para_koordinator pk) : base(success, message)
        {
            para_koor = pk;
        }

        public ParaKoordinatorResponse(para_koordinator para_koordinator) : this(true, string.Empty, para_koordinator) { }

        public ParaKoordinatorResponse(string message) : this(false, message, null){ }
    }
}