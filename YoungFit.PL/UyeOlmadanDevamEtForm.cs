using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungFit.PL
{
	public partial class UyeOlmadanDevamEtForm : Form
	{
		public UyeOlmadanDevamEtForm()
		{
			InitializeComponent();
		}

		private void btnBKIHesapla_Click(object sender, EventArgs e)
		{
			decimal kg, boy;
			if (decimal.TryParse(txtBoyCm.Text, out boy) && Convert.ToDecimal(txtBoyCm.Text) > 0)
			{
				kg = nudVucutAgirligi.Value;
				boy = Convert.ToDecimal(txtBoyCm.Text) / 100;
				string sonuc = string.Format("{0:n2}", kg / (boy * boy));
				lblBKI.Text = sonuc;
			}
			else
				MessageBox.Show("Yanlış değer girdiniz");
		}

		private void btnUyeOlIptal_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
