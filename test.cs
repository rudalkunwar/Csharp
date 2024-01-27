#include <graphics.h>
#include <math.h>
int main(){
	int gd=DETECT,gm;

	int x1,y1,x2,y2,sx,sy;
	printf("Enter the 2 line end points\n");
	printf("x1,y1,x2,y2\n");
	scanf("%d%d%d%d",&x1,&y1,&x2,&y2);
	printf("Enter translation Co-ordinate\n");
	printf("sx,sy\n");
	scanf("%d%d",&sx,&sy);
	initgraph(&gd,&gm,(char*)"");
	printf("Line after translation: ");
	line(x1,y1,x2,y2);
	x1=x1*sx;
	y1=y1*sy;
	x2=x2*sx;
	y2=y2*sy;
	printf("Line after Scaling: ");
	line(x1,y1,x2,y2);
	getch();
	closegraph();
}