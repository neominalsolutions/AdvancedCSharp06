using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCSharp06
{
  public partial class Form4 : Form
  {
    public Form4()
    {
      InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(textBox1.Text);

      // Js de bir işlemi kesip kod blogunun devam etmesi sağlanarak. callback yapıları ile kaynak kodu paralel de yürütülemesi için kullanılıyorsaç
      httpWebRequest.BeginGetResponse(new AsyncCallback(ResponseCallBack), httpWebRequest);

      MessageBox.Show("İşlem Async bırakıldı");

    }

    static void ResponseCallBack(IAsyncResult asyncResult)
    {

      HttpWebRequest request = (HttpWebRequest)asyncResult.AsyncState;

      try
      {

        HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(asyncResult);

        // Yanıtı okuma
        using (Stream responseStream = response.GetResponseStream())
        using (StreamReader reader = new StreamReader(responseStream))
        {
          string webData = reader.ReadToEnd();
          MessageBox.Show($"Veri Uzunluğu {webData.Length}");
        }

        // Yanıtı kapat
        response.Close();
      }
      catch (Exception)
      {

        throw;
      }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
      using (HttpClient client = new HttpClient())
      {
        // Asenkron olarak web sitesinden veri indirme
        string result = await client.GetStringAsync(textBox1.Text);
        MessageBox.Show($"Veri Uzunluğu {result.Length}");
      }
    }
  }
}
