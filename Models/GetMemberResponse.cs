﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTAPI.Models
{
    public class GetMemberResponse
    {
        public bool ok { get; set; }
        //取得指定會員資訊回應的錯誤訊息errMsg欄位為字串
        public string errMsg { get; set; }
        //取得指定會員資訊回應的資料data欄位為MemberInfo類型
        public MemberInfo data { get; set; }
        //初始化後將ok欄位設為true、errMsg欄位設為空字串、data欄位初始化
        public GetMemberResponse()
        {
            this.ok = true;
            this.errMsg = "";
            this.data = new MemberInfo();
        }
    }
}