using System.Collections.Generic;

namespace _053505_Malinovski_Lab8
{
    public interface IFileService
    {
        IEnumerable<Employee> ReadFile(string fileName);
        
        void SaveData(IEnumerable<Employee> data, string fileName);
    }
}