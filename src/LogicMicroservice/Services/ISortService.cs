using static LogicMicroservice.Services.SortService;

namespace LogicMicroservice.Services
{
    public interface ISortService
    {

        public MyList<int> BubbleSort(MyList<int> data);

    }
}
