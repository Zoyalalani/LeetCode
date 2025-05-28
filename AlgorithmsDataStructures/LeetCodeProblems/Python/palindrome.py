class Solution:
    def isPalindrome(self, x: int) -> bool:
        chars = list(str(x))
        print(chars)
        isPalindrome = True
        for i in range(len(chars)):
            if chars[i] != chars[len(chars)-1-i]:
                isPalindrome = False
        return isPalindrome




soln = Solution()
result = soln.isPalindrome(303)
print(result)