import random

number = [None] * 100
count = [None] * 100
countA = [None] * 100
rank = 0
ranksave = [None] * 100

#배열마다 랜덤값 부여 및 초기화
for i in range(0, 100):
	number[i] = random.randrange(1, 100)
	count[i] = 0
	
#겹치는 숫자가 몇개인지 세줌
for i in range(0, 100):
        for j in range(0, 100):
                if(number[i] == number[j]):
                        count[i] += 1
        #처음엔 무조건 더해지기에 빼줌
        count[i] -= 1

#순위를 구함
for i in range(0, 100):
        rank = 0
        #print("숫자",number[i], "갯수",count[i])
        for j in range(0, 100):
                if(count[i] < count[j]):
                        rank += 1
        ranksave[i] = rank + 1

for i in range(0, 100):
        print(i,"번","번호",number[i],"횟수",count[i],"순위",ranksave[i])
