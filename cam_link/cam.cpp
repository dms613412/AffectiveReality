
#include "camlink.hpp"


//#include <stdafx.h>

using namespace cv;
using namespace std;

int main() {
	int n;

	printf("������ ķ�� �Է��ϼ���(0-��Ʈ��, 1-��ķ) : ");
	cin >> n;
	camlink(n);

	return 0;
}
