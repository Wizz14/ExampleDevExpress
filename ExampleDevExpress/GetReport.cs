using System.Collections.Generic;
using System.IO;

namespace ExampleDevExpress
{
    public class GetReport
    {
        public static MemoryStream GetReportXXXXX()
        {

            List<Car> cars = new List<Car>();
            cars.Add(new Car() { Name = "01", Price = 500 });
            cars.Add(new Car() { Name = "02", Price = 1500 });
            cars.Add(new Car() { Name = "03", Price = 2500 });
            MemoryStream result = new MemoryStream();
            using (XtraReport report = new XtraReport())
            {
                report.DataSource = cars;   // bind object to report
                report.CreateDocument();
                report.ExportToPdf(result);
                report.Dispose();
            }

            result.Position = 0;
            return result;
        }
    }
}
