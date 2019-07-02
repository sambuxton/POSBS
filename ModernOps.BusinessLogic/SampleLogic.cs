using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernOps.CommonLibrary;
using ModernOps.Interface;


namespace ModernOps.BusinessLogic
{
    public class SampleLogic : ISample
    {
        public Task AddSample(SampleModel sample)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SampleModel>> GetSamples()
        {
            throw new NotImplementedException();
        }
    }
}
