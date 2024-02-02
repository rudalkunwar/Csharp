#include <graphics.h>
void WindowtoViewport(int x_w,int y_w , int x_wmax,int y_wmax,int x_wmin,int y_wmin,int x_vmax,int y_vmax,int x_vmin,int y_vmin){
	int x_v,y_v;
	float sx,sy;
	sx = float(x_vmax - x_vmin )/(x_wmax - x_wmin);
	sy = float(y_vmax - y_vmin )/(y_wmax - y_wmin);
	x_v = x_vmin + (float)((x_w - x_wmin)*sx);
	y_v = y_vmin + (float)((y_w - y_wmin)*sy);
	printf("The point on viewport: (%d,%d)\n",x_v,y_v);
}
int main()
{
	int gd=DETECT,gm;
	initgraph(&gd,&gm,(char *)"");
	int x_wmax = 80,y_wmax=80,x_wmin=20,y_wmin=40;
	int x_vmax = 60,y_vmax=60,x_vmin=30,y_vmin=40;
	int x_w = 30,y_w=80;
	WindowtoViewport(x_w, y_w , x_wmax, y_wmax, x_wmin, y_wmin, x_vmax, y_vmax, x_vmin, y_vmin);
	getch();
}