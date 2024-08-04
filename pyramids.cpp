#include <stdio.h>
#include <string.h>

typedef long long ll_t;

char S[400];
int P[400][400];
ll_t R[400][400];

static int MarkNum = 0; // mark number

ll_t F(int l, int r) {
  int i;
  if (l == r) return 1;
  if (P[l][r] == MarkNum) return R[l][r];
  P[l][r] = MarkNum, R[l][r] = 0;
  for (i = l + 1; i <= r; i++)
    if (S[i] == S[l])
      R[l][r] = (R[l][r] + F(l + 1, i - 1) * F(i, r)) % 1000000000;
  return R[l][r];
}

int main() {
  while (scanf ("%s", S) == 1) {
    MarkNum = MarkNum + 1;
    printf ("%lld\n", F(0, strlen(S) - 1));
  }
  return 0;
}