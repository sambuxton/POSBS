using ModernOps.CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernOps.Interface
{
    public interface ISample
    {
        Task<IEnumerable<SampleModel>> GetSamples();
        Task AddSample(SampleModel sample);
    }
}
