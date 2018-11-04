
#function
def fff(num):
    n= 1
    for i in range(1,num+1):
        n *=i
    sum = 0
    for i in range(len(str(n))):
        sum += int(str(n)[i])
    print(sum)
    
    
    
    
#main
while (True):
    try:
        m = input()
        fff(int(m))
    except EOFError:        
        break

