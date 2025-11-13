// See https://aka.ms/new-console-template for more information
using ClassLib;
using Microsoft.Reporting.NETCore;
using Microsoft.ReportingServices.Interfaces;

Console.WriteLine("Hello, World!");
var _dataRepository = new DataRepository();
var localReport = new LocalReport();
var data = _dataRepository.GetSampleData();


localReport.DataSources.Add(new ReportDataSource("DataSet1", data));
localReport.ReportPath = Path.Combine(AppContext.BaseDirectory, "Reports", "Report1.rdlc");
Console.WriteLine("Rendering report...");
byte[] result = localReport.Render("PDF");

// Save output
string outputPath = Path.Combine(AppContext.BaseDirectory, "docs\\ReportOutput.pdf");
File.WriteAllBytes(outputPath, result);
Console.WriteLine($"✅ Report generated: {outputPath}");
