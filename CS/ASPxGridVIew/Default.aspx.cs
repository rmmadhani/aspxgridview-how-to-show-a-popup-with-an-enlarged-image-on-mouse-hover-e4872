using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxGridView;
using DevExpress.XtraCharts.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPxGridVIew {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            ASPxGridView1.DataSource = DataHelper.GenerateData();
            ASPxGridView1.DataBind();
        }

        protected void ASPxGridView1_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewTableDataCellEventArgs e) {
            if (e.DataColumn.FieldName == "ImageUrl") {
                e.Cell.Attributes.Add("onmouseover", string.Format("ShowPopup('{0}','{1}','{2}')", e.Cell.ClientID, e.GetValue("ImageUrl"), e.GetValue("Description")));
            }
        }
    }
}