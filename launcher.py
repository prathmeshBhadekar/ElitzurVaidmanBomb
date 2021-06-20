import qsharp
from ElitzurVaidmanBomb import EVBTest

noOfTrials = 1000
guessRight = 0
for _ in range(noOfTrials):
    res = EVBTest.simulate()
    if res:
        guessRight += 1

accuracy = (1.0 * guessRight)/noOfTrials
print("Percentage when guess was right : ", accuracy*100)

