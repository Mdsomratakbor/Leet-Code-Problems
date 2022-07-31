public class RemoveElement
{
    public int RemoveElementMethod(int[] nums, int val) {
     
        int arraySize =nums.Length; 
        if(arraySize==0)
            return 0;
        int valid_size=0;
        for(int i=0; i<arraySize; i++){
            if(nums[i]!= val)
               nums[ valid_size++]=nums[i];
        }
        return valid_size;
    }
}
