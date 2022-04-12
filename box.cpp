
#include <stdio.h>

const int n_max = 6;

int q[n_max];
int a[n_max][2];
int t[n_max];

const int f[n_max][n_max][2] = 
{
	{{-1, -1}, {1, 0}, {0, 0}, {0, 0}, {1, 1}, {-1, -1}},
	{{0, 1}, {-1, -1}, {1, 1}, {1, 1}, {-1, -1}, {0, 0}},
	{{0, 0}, {1, 1}, {-1, -1}, {-1, -1}, {1, 0}, {0, 1}},
	{{0, 0}, {1, 1}, {-1, -1}, {-1, -1}, {1, 0}, {0, 1}},
	{{1, 1}, {-1, -1}, {0, 1}, {0, 1}, {-1, -1}, {1, 0}},
	{{-1, -1}, {0, 0}, {1, 0}, {1, 0}, {0, 1}, {-1, -1}}
};

int check(int);
int box(int, int*, int*);

int main() {
	int i, e[6];

	fclose(stdin); fopen("box.in", "r");
	fclose(stdout);fopen("box.out","w");

	for(i = 0;i < 6;i++)
		scanf("%d %d", &a[i][0], &a[i][1]);

	for(i = 0;i < 6;i++)
		e[i] = 0;

	if(box(0, e, q))
		puts("POSSIBLE");
	else
		puts("IMPOSSIBLE");
	return 0;
}

int box(int s, int *e, int *p) {
	int i;

	if(s == 6) {
		for(i = 0;i < 6;i++)
			q[i] = p[i];

		for(i = 0;i < 64;i++)	
			if(check(i))
				return 1;
		return 0;
	}

	for(i = 0;i < 6;i++)
		if(!e[i]) {
			p[s] = i;
			e[i] = 1;
			if(box(s + 1, e, p))
				return 1;
			e[i] = 0;
		}	
	return 0;
}

int check(int m) {
	int i, j;

	for(i = 0;i < 6;i++)
		for(j = 0;j < 6;j++)
			if(f[i][j][0] != -1)
				if(a[q[i]][f[i][j][0] ^ ((m >> i) & 1)]
						!= a[q[j]][f[i][j][1] ^ ((m >> j) & 1)])
					return 0;
	return 1;
}
