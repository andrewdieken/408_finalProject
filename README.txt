References 

1)// Creating a Excel object. Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application(); Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing); Microsoft.Office.Interop.Excel._Worksheet worksheet = null; try { worksheet = workbook.ActiveSheet; worksheet.Name = "ExportedFromDatGrid"; int cellRowIndex = 1; int cellColumnIndex = 1; //Loop through each row and read value from each column. for (int i = 0; i < dgvCityDetails.Rows.Count - 1; i++) { for (int j = 0; j < dgvCityDetails.Columns.Count; j++) { // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. if (cellRowIndex == 1) { worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCityDetails.Columns[j].HeaderText; } else { worksheet.Cells[cellRowIndex, cellColumnIndex] = dgvCityDetails.Rows[i].Cells[j].Value.ToString(); } cellColumnIndex++; } cellColumnIndex = 1; cellRowIndex++; } //Getting the location and file name of the excel to save from user. SaveFileDialog saveDialog = new SaveFileDialog(); saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"; saveDialog.FilterIndex = 2; if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) { workbook.SaveAs(saveDialog.FileName); MessageBox.Show("Export Successful"); } } catch (System.Exception ex) { MessageBox.Show(ex.Message); } finally { excel.Quit(); workbook = null; excel = null; }


Old Way to write to CSV file for records :
                ////fill sb with info from datatable
                //StringBuilder sb = new StringBuilder();
                //IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                //sb.AppendLine(string.Join(",", columnNames));
                ////
                //foreach (DataRow row in dt.Rows)
                //{
                //    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                //    sb.AppendLine(string.Join(",", fields));
                //}
                //File.WriteAllText("AllAthletes.csv", sb.ToString());