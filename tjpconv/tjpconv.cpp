// tjpconv
// a minimalist TJP library demo application
// G. Covoni 18/12/2014 


#include "stdafx.h"
#include "windows.h"


HRESULT WINAPI StartInit(void);

HRESULT WINAPI SetBarcode( 
  _In_   BYTE *barcodedef
);

HRESULT WINAPI StartInit(void);

HRESULT WINAPI StartDocument(void);

HRESULT WINAPI LoadInitBitmap(
  _In_   LPWSTR lpBmpFilename,
  _In_   UINT uId
);

HRESULT WINAPI EndInit(
  _In_   LPWSTR lpRbdFilename,
  _Out_  LPSTR lpBuffer,
  _In_   UINT uSize
);

HRESULT WINAPI LoadDocumentField(
  _In_   LPWSTR lpField,
  _In_   UINT uId
);

HRESULT WINAPI LoadDocumentBarcode(
  _In_   LPWSTR lpBarcodeData,
  _In_   UINT uId,
  _In_   UINT uZoom
);

HRESULT WINAPI EndDocument(
  _In_   TCHAR wDocType,
  _Out_  LPSTR lpBuffer,
  _In_   UINT uSize
);

HRESULT WINAPI GetDimensions(
  _In_   LPWSTR	lpRbdFilename,
  _Out_  LPDWORD lpWidth,
  _In_   LPDWORD lpHeight
);



#define TJP_SUCCESS	0
#define BUFSIZE (1024*16)

int _tmain(int argc, _TCHAR* argv[])
{
	int ret;
	if ( argc < 3) {
		fwprintf( stderr, L"Usage: [command] file.rbd [image1.bmp] [image2.bmp] [image3.bmp]\n");
		fwprintf( stderr, L"\tI convert rbd file\n");
		fwprintf( stderr, L"\tS show item size\n");
		ret = 0;
	} else {
		switch(argv[1][0]) {
			case 's':
			case 'S':
				DWORD w, h;
				ret = GetDimensions(argv[2], &w, &h);
				if ( ret == TJP_SUCCESS)
					printf( "item size:\nWidth is %.1f mm\nHeight is %.1f mm\n", w/10.0, h/10.0);
			break;
			case 'i':
			case 'I':
				
				StartInit();

				if ( argc > 3) {
					ret = LoadInitBitmap( argv[3], 1);
					if (ret != TJP_SUCCESS)
						break;
				} if ( argc > 4) {
					ret = LoadInitBitmap( argv[4], 2);
					if (ret != TJP_SUCCESS)
						break;
				} if ( argc > 5) {
					ret = LoadInitBitmap( argv[5], 3);
					if (ret != TJP_SUCCESS)
						break;
				}

				char room[BUFSIZE];
				ret = EndInit(argv[2], room, BUFSIZE);
				if ( ret == TJP_SUCCESS) {
					printf( room);
					putchar('\n');
				}
			break;
			default:
				ret = -1;
			break;
		}
	}
	if ( ret != TJP_SUCCESS)
		fwprintf( stderr, L"error %d\n", ret);
	return ret;
}

