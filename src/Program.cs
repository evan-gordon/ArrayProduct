using System;

namespace src
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public int[] ProductExceptSelf(int[] nums)
    {
      LeftProduct(ref nums, out int[] left);
      RightProduct(ref nums, out int[] right);
      int[] r = new int[nums.Length];
      for (int i = 0; i < nums.Length; ++i)
      {
        r[i] = left[i] * right[i];
      }


      return r;
    }

    public void LeftProduct(ref int[] nums, out int[] left)
    {
      left = new int[nums.Length];
      left[0] = 1;

      for (int i = 1; i < nums.Length; ++i)
      {
        left[i] = nums[i - 1] * left[i - 1];
      }
    }

    public void RightProduct(ref int[] nums, out int[] right)
    {
      right = new int[nums.Length];
      right[nums.Length - 1] = 1;

      for (int i = nums.Length - 2; i >= 0; --i)
      {
        right[i] = nums[i + 1] * right[i + 1];
      }
    }
  }
}
