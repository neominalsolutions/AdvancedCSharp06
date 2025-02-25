using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCSharp06
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
      txtSearch.Text = "Thread " + Thread.CurrentThread.ManagedThreadId;
    }

    private void btnFill_Click(object sender, EventArgs e)
    {


      // çapraz thread çağırısı için bu özelliği windows form ortamında açtık
      Control.CheckForIllegalCrossThreadCalls = false;

      // ayrı bir iş parçacığı açtık
      Thread t1 = new Thread(ListBox1Doldur);
      t1.Start(); // thread başlattık

      Thread t2 = new Thread(ListBox2Doldur);
      t2.Start();

      Thread t3 = new Thread(ListBox3Doldur);
      t3.Start();
    }

    private void ListBox1Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {


        Thread.Sleep(1000); // 1 saniye de bir girilsin

        listBox1.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}");
      }
    }

    private void ListBox2Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
        Thread.Sleep(1000); // 1000 ms 1 saniye de bir girilsin

        listBox2.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}");
      }
    }

    private void ListBox3Doldur()
    {
      for (int i = 1; i <= 3; i++)
      {
        Thread.Sleep(1000); // 1 saniye de bir girilsin


        listBox3.Items.Add($"{i}, threadId: {Thread.CurrentThread.ManagedThreadId}");
      }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
