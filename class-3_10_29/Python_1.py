
n = input()
if n == "1":
    m = str(input())
    s = ""
    for i in range(0,len(m)):
        s +=str(ord(m[i])*3)            
    print(s)    
else:
    m = str(input())
    s = ""
    ans = ""
    for i in range(0,len(m),3):
        s = m[i]+m[i+1]+m[i+2]
        ans += chr(int(int(s)/3))
    print(ans)

