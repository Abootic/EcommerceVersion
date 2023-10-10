
namespace EcommereceWeb.Application.Wrapper
{
    public class DtResult<T>
    {
        public int drew { get; set; }
        public int recordTotal { get; set; }
        public int recordFilter { get; set; }
        public IEnumerable<T> data { get; set; }
        public string error { get; set; }
        public static DtResult<T> DataTableFactory() { return new DtResult<T>(); }
        public static DtResult<T> DataTableFactory(int recordTotal,int recordFilter, IEnumerable<T> data)
        {
            return new DtResult<T>
            {
                recordTotal = recordTotal,
                recordFilter = recordFilter,
                data = data
            };
        }
        public static DtResult<T> DataTableFactory(int recordTotal,int recordFilter, IEnumerable<T> data,string error)
        {
            return new DtResult<T>
            {
                recordTotal = recordTotal,
                recordFilter = recordFilter,

                data = data,
                error = error
            };
        }
        public static DtResult<T> DataTableFactory(int drew,int recordTotal,int recordFilter, IEnumerable<T> data,string error)
        {
            return new DtResult<T>
            {
                recordTotal = recordTotal,
                recordFilter = recordFilter,
                data = data,
                error = error
            };
        }
       
    }
}
