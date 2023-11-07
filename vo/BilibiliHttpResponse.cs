using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatCatNG.vo
{
    /*
     * struct like this "
     * {
     *       "code": 0,
     *      "status": true,
     *       "ts": 1699348050,
     *       "data": {
     *           "url": "https://passport.bilibili.com/qrcode/h5/login?oauthKey=ssssssssssssssss",
     *           "oauthKey": "ssssssssssssssssssssssssssss"
     *       }
     *   }"
     * 
     * **/
    public class BilibiliHttpResponse
    {
        public int Code { get; set; }
        public bool Status { get; set; }
        public long Ts { get; set; }
        public BilibiliLoginResponseData? Data { get; set; }
    }
}
