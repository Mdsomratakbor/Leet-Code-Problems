public class Solution {
public int SingleNumber(int[] nums) {
return nums.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key).First();

}
}
