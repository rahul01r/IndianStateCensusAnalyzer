using StateCensusAnalyser.DTO;
using StateCensusAnalyser.UsingCode;

namespace StateCensusAnalyser
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to IndianStatesCensusAnalyser ");
            string filePathStateCensus = @"C:\Users\Lenovo\Desktop\Git\IndianStateCensusAnalyzer\StateCensusAnalyser\DTO\StateCensus.csv";
            string filePath = @"C:\Users\Lenovo\Desktop\Git\IndianStateCensusAnalyzer\StateCensusAnalyser\UsingCode\StateCode.csv";

            StateCensusAnalyzer analyzer = new StateCensusAnalyzer();
            int StateCensusRecords = analyzer.ReadStateCensusData(filePathStateCensus);
            CSVStateCensus census = new CSVStateCensus();
            int censusRecords = census.ReadStateCensusData(filePathStateCensus);
            if (StateCensusRecords == censusRecords)
                Console.WriteLine("Number of records match");

            StateCodeAnalyzer stateCodeAnalyzer = new StateCodeAnalyzer();
            int StateCodeRecords = stateCodeAnalyzer.ReadStateCodeData(filePath);
            CSVStateCensus stateCode = new CSVStateCensus();
            int codeRecords = stateCode.ReadStateCodeData(filePath);
            if (StateCodeRecords == codeRecords)
                Console.WriteLine("Number of records match");
        }
    }
}