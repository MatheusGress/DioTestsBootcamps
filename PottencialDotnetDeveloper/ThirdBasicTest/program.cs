using System;

class Solution {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 1; i <= n; i++) {
            if (n % i == 0) {
                count++;
            }
            if (count > 3) {
                Console.WriteLine(false);
                return;
            }
        }

        Console.WriteLine(count == 3);
    }
}
