#include "camlink.hpp"

int camlink(int n) {
#if defined(_WIN64)
	//#include <stdafx.h>
	VideoCapture cap;
	cap.open(n);
	if (!cap.isOpened()) {
		cout << "could not open the VideoCapture !" << endl;
		return -1;
	}
	while (true) {
		Mat frame;
		bool ok = cap.read(frame);

		if (!ok)
			break;

		flip(frame, frame, 1);
		imshow("ocv", frame);
		int k = waitKey(10);
		if (k == 27) break;
	}

	return 0;

#elif defined(__APPLE__) 
#include <iostream>
#include <opencv2/opencv.hpp>
#include <opencv/highgui.h>

	//#include <stdafx.h>

	using namespace cv;
	using namespace std;

	cout << "macÀÔ´Ï´Ù" << endl;
	VideoCapture cap;
	cap.open(0);
	if (!cap.isOpened()) {
		cout << "could not open the VideoCapture !" << endl;
		return -1;
	}
	while (true) {
		Mat frame;
		bool ok = cap.read(frame);

		if (!ok)
			break;

		flip(frame, frame, 1);
		imshow("ocv", frame);
		int k = waitKey(10);
		if (k == 27) break;
	}

	return 0;

#endif
}
