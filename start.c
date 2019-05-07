#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char *argv[]) {
	int number[100];
	int count[100];
	int countA[100];
	int i, j, rank;

	srand(time(NULL));
	for(i=0; i<100; i++){
		number[i] = rand() % 101;
		count[i] = 0;
	}
	
	for(i=0; i<100; i++){
		for(j=0; j<100; j++){
			if(number[i] == number[j]){
				count[i] ++;
			}
		}
	
		count[i] -= 1;
		printf("%d: %d\n", number[i], count[i]);
		
		for(i=0; i<100; i++)
		{
			rank = 1;
			for(j=0; j<100; j++){
				if(count[i] < count[j]){
					rank ++;
				}
				countA[i] = rank;
			}
		}
	}
	
	for(i=0; i<100; i++){
		if(countA[i] == 1){
			printf("1등은? %d번 %d번 나왔음\n", number[i], count[i]);
			break;
		}
	}

	return 0;
}