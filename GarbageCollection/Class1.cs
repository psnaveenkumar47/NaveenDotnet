using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace GarbageCollection
{
    class Employee:IDisposable
    {
        private bool _disposed;
        private int id;
        public int Salary;
        public Employee( int id)
        {
           this._disposed = false;
            this.id = id;
            Console.WriteLine($"object instantiateed for id:{this.id}");
        }       
        ~Employee()
        {
            if(!_disposed)
            {
                this.Dispose();
            }
            Console.WriteLine($"Object Destroyed for id: {this.id}");
        }
        public TimeSpan MonitoringTotalProcessTime
        { get;
        }
        public void WorkStatus()
        {
            if(this._disposed)
            {
                throw new ObjectDisposedException(this.id.ToString(), "Employee has been Terminated");
            }
            else
            {
                Console.WriteLine($"id= {this.id} is working properly");
                Console.WriteLine(MonitoringTotalProcessTime.ToString());
            }
        }
        public long MonitoringTotalAllocatedMemorySize
        { get; }
        public void IncrementSalary(int increment)
        {
            if(this._disposed)
            {
                throw new ObjectDisposedException(this.id.ToString()," Employee has been Terminated");
            }
            else
            {
                Console.WriteLine($"salary Incremented for employee id: {this.id}");
                Console.WriteLine(MonitoringTotalAllocatedMemorySize.ToString());
                this.Salary += increment;
            }
        }
        public void Dispose()
        {
            Console.WriteLine($"{this.id} is being disposed");
            Console.WriteLine(MonitoringTotalAllocatedMemorySize.ToString());
            GC.SuppressFinalize(this);
            this._disposed = true;
        }
      

    }
}
