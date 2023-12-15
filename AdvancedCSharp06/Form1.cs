namespace AdvancedCSharp06
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnFill_Click(object sender, EventArgs e)
    {
      ListBox1Doldur();
      ListBox2Doldur();
      ListBox3Doldur();
    }

    private void ListBox1Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
        Thread.Sleep(1000); // 1 saniye de bir girilsin
        listBox1.Items.Add(i);
      }
    }

    // Thread yap�l�r� i�letim sistemindeki bir i� par�ac���n� temsil eder
    // i�lems sistemleri ayn� anda paralel de birden fazla i� par�ac���n� �al��t�rabilmek i�in Thread yap�lar�n� kullan�z.
    // Multi Tasking (�oklu Thread Yap�s�)
    // Bilgisyar�n Core (�ekirdek g�v�ne g�re de�i�ir)
    // Programla dilleri ise 
    // Form uygulama gibi uygulamada UI Thread 1 tane oldu�undan otomatik olarak hepsi ayn� anda ekrana bas�l�yor. ��lem yap�lana kadar da UI donuyor.

    // Asenkron => e�zamans�z programlama => farkl� i� par�ac�klar� olu�turarak i�leri paralelde y�netmek. Her bir i�i i�in bir kaynak kullan�m arka planda Main UI thread yap�s�n� etkilenmeden i�lemleri ��z�mlemek. 


    private void ListBox2Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
        Thread.Sleep(1000); // 1 saniye de bir girilsin
        listBox2.Items.Add(i);
      }
    }

    private void ListBox3Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
        Thread.Sleep(1000); // 1 saniye de bir girilsin
        listBox3.Items.Add(i);
        
      }
    }
  }
}