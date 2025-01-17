//using MSY.Helpers;
using MSY.Models;
//using Irony.Parsing.Construction;
//using Microsoft.AspNet.Identity;
//using Newtonsoft.Json;
//using SubSonic.Extensions;
//using SubSonic.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.Entity;
//using System.Data.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
//using System.Windows.Interop;

namespace MSY.Manager
{
    public class CommonModel
    {
        private static msyEntities _db = new msyEntities();

        public static List<SelectListItem> GetALLJC(int IsSelect = 0)
        {
            msyEntities _db = new msyEntities();
            List<SelectListItem> list = new List<SelectListItem>();
            list = _db.Tbl_JobCard.OrderBy(JC => JC.OrderBy).Select(JC => new SelectListItem { Value = JC.id.ToString(), Text = JC.jobCardNumber }).ToList();
            if (IsSelect == 0)
            {
                list.Insert(0, new SelectListItem { Value = "", Text = "Select" });
            }
            else if (IsSelect == 1)
            {
                list.Insert(0, new SelectListItem { Value = "", Text = "All" });
            }

            return list;
        }

    }



       
}