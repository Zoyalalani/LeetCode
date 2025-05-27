class Solution:
    def difference_of_sums(self, n,m) -> int:
        divisible = 0
        not_divisible = 0
        for i in range(1, n + 1):
            if i % m == 0:
                divisible += i
            else:
                not_divisible += i
        return not_divisible - divisible

s= Solution()
result = s.difference_of_sums(4,5)
print (result)