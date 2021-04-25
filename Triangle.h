class Triangle {
public:
	Triangle(double* initPoint1, double* initPoint2, double* initPoint3, double* initNormal) {
		point1 = initPoint1;
		point2 = initPoint2;
		point3 = initPoint3;
		normal = initNormal;
	}
private:
	double* point1;
	double* point2;
	double* point3;
	double* normal;
};