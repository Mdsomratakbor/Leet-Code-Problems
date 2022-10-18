using System.Linq;

public class ThirdMaximumNumber{
   public int ThirdMax(int[] nums) {
          var arr =nums.Distinct().ToArray();  
      arr = arr.OrderByDescending(c => c).ToArray();
        if(arr.Length<3)
        return arr[0];
        else
            return arr[2];
        
    }
    }
