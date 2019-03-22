
#include "camlink.hpp"


//#include <stdafx.h>

using namespace cv;
using namespace std;

int main() {
	int n;

	printf("¿¬°áÇÒ Ä·À» ÀÔ·ÂÇÏ¼¼¿ä(0-³ëÆ®ºÏ, 1-À¥Ä·) : ");
	cin >> n;
	camlink(n);

	return 0;
}
