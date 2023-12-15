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

    // Thread yapýlýrý iþletim sistemindeki bir iþ parçacýðýný temsil eder
    // iþlems sistemleri ayný anda paralel de birden fazla iþ parçacýðýný çalýþtýrabilmek için Thread yapýlarýný kullanýz.
    // Multi Tasking (Çoklu Thread Yapýsý)
    // Bilgisyarýn Core (Çekirdek güvüne göre deðiþir)
    // Programla dilleri ise 
    // Form uygulama gibi uygulamada UI Thread 1 tane olduðundan otomatik olarak hepsi ayný anda ekrana basýlýyor. Ýþlem yapýlana kadar da UI donuyor.

    // Asenkron => eþzamansýz programlama => farklý iþ parçacýklarý oluþturarak iþleri paralelde yönetmek. Her bir iþi için bir kaynak kullaným arka planda Main UI thread yapýsýný etkilenmeden iþlemleri çözümlemek. 


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