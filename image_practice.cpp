#include <iostream>
#include <opencv2/opencv.hpp>


int main(void)
{
	cv::Mat srcImg = cv::imread("Lenna.png");

	cv::imshow("srcImg", srcImg);

	cv::waitKey(0);
	return 0;
}
