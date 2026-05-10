using System.Text;

namespace ContosoPizza.Services;

public static class SalesService
{
    public static string GenerateSalesSummary(string directoryPath)
    {
        if (!Directory.Exists(directoryPath))
        {
            return "Sales directory not found.";
        }

        var files = Directory.GetFiles(directoryPath, "*.txt");
        if (files.Length == 0)
        {
            return "No sales files found.";
        }

        decimal totalSales = 0;
        var details = new StringBuilder();

        foreach (var file in files)
        {
            var content = File.ReadAllText(file);
            if (decimal.TryParse(content.Trim(), out decimal sales))
            {
                totalSales += sales;
                details.AppendLine($"  {Path.GetFileName(file)}: ${sales:N2}");
            }
        }

        var summary = new StringBuilder();
        summary.AppendLine("Sales Summary");
        summary.AppendLine("----------------------------");
        summary.AppendLine($" Total Sales: ${totalSales:N2}");
        summary.AppendLine();
        summary.AppendLine(" Details:");
        summary.Append(details.ToString());

        return summary.ToString();
    }
}