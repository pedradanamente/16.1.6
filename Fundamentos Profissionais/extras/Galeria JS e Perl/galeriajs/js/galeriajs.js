var siM = function () {
	/* ---- private vars ---- */
	var obj = [], scr, spa, cap, img, W, Wi, Hi, wi, hi, Sx, Sy, M;
	var xb = 0, yb = 0, ob =  - 1;
	//////////////////////////////////////////////////////////
	var Nx = 2; //size grid x
	var Ny = 2; //size grid y
	var Tx = 2; // image width
	var Ty = 2; // image height
	var Mg = 10; // margin
	var SP = 0.7; // speed
	//////////////////////////////////////////////////////////
	var Cobj = function (o, x, y) {
		this.o = o;
		this.ix = Math.min(Nx - Tx, Math.max(0, Math.round(x - (Tx / 2))));
		this.iy = Math.min(Ny - Ty, Math.max(0, Math.round(y - (Ty / 2))));
		this.li = ((this.ix * M + this.ix * Sx) - (x * M + x * Sx)) / SP;
		this.ti = ((this.iy * M + this.iy * Sy) - (y * M + y * Sy)) / SP;
		this.x = x;
		this.y = y;
		this.l = 0;
		this.t = 0;
		this.w = 0;
		this.h = 0;
		this.s = -1;
		this.spa = spa[o].style;
		this.img = img[o];
		this.txt = img[o].alt;
		this.img.alt = "";
		/* center image */
		this.img.center = function () {
			this.style.left = Math.round( -(this.width - Wi) / 2) + "px";
			this.style.top  = Math.round( -(this.height - Hi) / 2) + "px";
		}
		/* events */
		this.img.onclick = function () {
			obj[o].click();
		}
		this.img.onload = function () {
			this.center();
		}
		/* initial display */
		this.zoom();
	}
	/* zooming loop */
	Cobj.prototype.zoom = function() {
		this.f = false;
		this.l += this.li * this.s;
		this.t += this.ti * this.s;
		this.w += wi * this.s;
		this.h += hi * this.s;
		if ((this.s > 0 && this.w < Wi) || (this.s < 0 && this.w > Sx)) {
			/* loop */
			var o = this.o;
			setTimeout(function() {
				obj[o].zoom();
			}, 16);
		} else {
			/* finished */
			if (this.s > 0) {
				this.l = this.ix * M + this.ix * Sx;
				this.t = this.iy * M + this.iy * Sy;
				this.w = Wi;
				this.h = Hi;
			} else {
				this.l = this.x * M + this.x * Sx;
				this.t = this.y * M + this.y * Sy;
				this.w = Sx;
				this.h = Sy;
			}
		}
		/* html animation */
		this.spa.left   = Math.round(this.l) + "px";
		this.spa.top    = Math.round(this.t) + "px";
		this.spa.width  = Math.round(this.w) + "px";
		this.spa.height = Math.round(this.h) + "px";
		this.spa.zIndex = Math.round(this.w);
	}

	Cobj.prototype.click = function() {
		this.img.center();
		/* zooming logic */
		if (this.s > 0) {
			this.s = -1;
			this.zoom();
			cap.innerHTML = this.txt;
		} else if (this.s < 0) {
			if (ob >= 0) {
				obj[ob].s =  - 1;
				obj[ob].zoom();
			}
			ob = this.o;
			this.s = 1;
			this.zoom();
			cap.innerHTML = this.txt;
		}
	}
	/* ====== init script ====== */
	var init = function () {
		/* html elements */
		scr = document.getElementById("screen");
		spa = scr.getElementsByTagName("span");
		img = scr.getElementsByTagName("img");
		cap = document.getElementById("caption");
		
		/* variables */
		W = scr.offsetWidth;
		H = scr.offsetHeight;
		M = W / 40;
		Sx = (W - (Nx - 1) * M) / Nx;
		Sy = (H - (Ny - 1) * M) / Ny;
		Wi = Tx * Sx + (Tx - 1) * M;
		Hi = Ty * Sy + (Ty - 1) * M;
		SP = M * Tx * SP;
		wi = (Wi - Sx) / SP;
		hi = (Hi - Sy) / SP;
	
		/* create objects */
		for (var k = 0, i = 0; i < Nx; i++) {
			for (var j = 0; j < Ny; j++)
				obj[k] = new Cobj(k++, i, j);
		}
	}
	return {
		init : init
	}
}();