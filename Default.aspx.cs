using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sriramaproject
{
	public partial class _Default : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			txtName.Text = "How are you?";
		}
	}
}