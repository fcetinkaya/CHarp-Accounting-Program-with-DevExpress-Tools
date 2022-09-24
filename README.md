# C# Accounting Program with DevExpress Tools
 C# Accounting Program with DevExpress Tools (Windows Application)


## Table of contents
* [General info](#general-info)
* [Screenshots](#screenshots)
* [Projects](#Projects)
* [Code Examples](#code-examples)

## General info
Those who want to improve themselves on Windows desktop application by using C # technology can benefit.
- SQL Server database is used.
- DevExpress Tools are used.
- You will learn OOP structure and classic .Net structure.


## Screenshots
![Example screenshot](screenshot/AccountantProgram_MainScreen.JPG)
![Example screenshot](screenshot/AccountantProgram_InvoiseScreen.JPG)
![Example screenshot](screenshot/AccountantProgram_BankScreen.jpg)
![Example screenshot](screenshot/AccountantProgram_CustomerScreen.jpg)
![Example screenshot](screenshot/AccountantProgram_StockScreen.jpg)




## Projects
1. C# Windows Application
2. DevExpress Tools
3. .Net 4.5 Clasic
4. Object Orient Programing
5. SQL Server Database


## Code Examples
Show examples of usage:
```
  DialogResult dlg = MessageBox.Show("İş Emri Sisteme Kaydedilsin mi?", "Kaydetme Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dlg == DialogResult.Yes)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                try
                {
                    OleDbCommand com = new OleDbCommand("Insert Into IsEmri(MusteriID,YapilanIsID,Kontrol,PersonelID,MatbaaID,Baslangic) values(@M,@Y,@K,@P,@MID,@B)", con);
                    com.Parameters.AddWithValue("@M", Convert.ToInt32(mustericombo.SelectedValue));
                    com.Parameters.AddWithValue("@Y", Convert.ToInt32(Yapilancombo.SelectedValue));
                    com.Parameters.AddWithValue("@K", durumcombo.Text.ToString());
                    com.Parameters.AddWithValue("@P", Convert.ToInt32(personelcombo.SelectedValue));
                    com.Parameters.AddWithValue("@MID", Convert.ToInt32(Matbaacombo.SelectedValue));
                    com.Parameters.AddWithValue("@B", dateTimePicker1.Value.ToLongDateString());
                    if (com.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Kayıt Yapıldı.");
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.ToString());
                }
                finally { con.Close(); }
            }

```
