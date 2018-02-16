/* This source code was produced by mkbundle, do not edit */

#ifndef NULL
#define NULL (void *)0
#endif

typedef struct {
	const char *name;
	const unsigned char *data;
	const unsigned int size;
} MonoBundledAssembly;
void          mono_register_bundled_assemblies (const MonoBundledAssembly **assemblies);
void          mono_register_config_for_assembly (const char* assembly_name, const char* config_xml);

typedef struct _compressed_data {
	MonoBundledAssembly assembly;
	int compressed_size;
} CompressedAssembly;

extern const unsigned char assembly_data_HAIS_DailyFuel_APP_Android_dll [];
static CompressedAssembly assembly_bundle_HAIS_DailyFuel_APP_Android_dll = {{"HAIS.DailyFuel.APP.Android.dll", assembly_data_HAIS_DailyFuel_APP_Android_dll, 152064}, 54698};
extern const unsigned char assembly_config_HAIS_DailyFuel_APP_Android_dll [];
extern const unsigned char assembly_data_Behaviors_dll [];
static CompressedAssembly assembly_bundle_Behaviors_dll = {{"Behaviors.dll", assembly_data_Behaviors_dll, 28160}, 12088};
extern const unsigned char assembly_data_FormsViewGroup_dll [];
static CompressedAssembly assembly_bundle_FormsViewGroup_dll = {{"FormsViewGroup.dll", assembly_data_FormsViewGroup_dll, 12800}, 4961};
extern const unsigned char assembly_data_Newtonsoft_Json_dll [];
static CompressedAssembly assembly_bundle_Newtonsoft_Json_dll = {{"Newtonsoft.Json.dll", assembly_data_Newtonsoft_Json_dll, 635904}, 238452};
extern const unsigned char assembly_data_Plugin_CurrentActivity_dll [];
static CompressedAssembly assembly_bundle_Plugin_CurrentActivity_dll = {{"Plugin.CurrentActivity.dll", assembly_data_Plugin_CurrentActivity_dll, 5120}, 2135};
extern const unsigned char assembly_data_Plugin_Geolocator_Abstractions_dll [];
static CompressedAssembly assembly_bundle_Plugin_Geolocator_Abstractions_dll = {{"Plugin.Geolocator.Abstractions.dll", assembly_data_Plugin_Geolocator_Abstractions_dll, 12800}, 5099};
extern const unsigned char assembly_data_Plugin_Geolocator_dll [];
static CompressedAssembly assembly_bundle_Plugin_Geolocator_dll = {{"Plugin.Geolocator.dll", assembly_data_Plugin_Geolocator_dll, 26624}, 11865};
extern const unsigned char assembly_data_Plugin_Permissions_Abstractions_dll [];
static CompressedAssembly assembly_bundle_Plugin_Permissions_Abstractions_dll = {{"Plugin.Permissions.Abstractions.dll", assembly_data_Plugin_Permissions_Abstractions_dll, 4608}, 1859};
extern const unsigned char assembly_data_Plugin_Permissions_dll [];
static CompressedAssembly assembly_bundle_Plugin_Permissions_dll = {{"Plugin.Permissions.dll", assembly_data_Plugin_Permissions_dll, 15872}, 6898};
extern const unsigned char assembly_data_SQLite_net_dll [];
static CompressedAssembly assembly_bundle_SQLite_net_dll = {{"SQLite-net.dll", assembly_data_SQLite_net_dll, 71168}, 31824};
extern const unsigned char assembly_data_SQLite_Net_Async_dll [];
static CompressedAssembly assembly_bundle_SQLite_Net_Async_dll = {{"SQLite.Net.Async.dll", assembly_data_SQLite_Net_Async_dll, 19456}, 7048};
extern const unsigned char assembly_data_SQLite_Net_dll [];
static CompressedAssembly assembly_bundle_SQLite_Net_dll = {{"SQLite.Net.dll", assembly_data_SQLite_Net_dll, 78336}, 34068};
extern const unsigned char assembly_data_SQLite_Net_Platform_XamarinAndroid_dll [];
static CompressedAssembly assembly_bundle_SQLite_Net_Platform_XamarinAndroid_dll = {{"SQLite.Net.Platform.XamarinAndroid.dll", assembly_data_SQLite_Net_Platform_XamarinAndroid_dll, 14336}, 5806};
extern const unsigned char assembly_data_SQLiteNetExtensions_dll [];
static CompressedAssembly assembly_bundle_SQLiteNetExtensions_dll = {{"SQLiteNetExtensions.dll", assembly_data_SQLiteNetExtensions_dll, 36864}, 15091};
extern const unsigned char assembly_data_SQLiteNetExtensionsAsync_dll [];
static CompressedAssembly assembly_bundle_SQLiteNetExtensionsAsync_dll = {{"SQLiteNetExtensionsAsync.dll", assembly_data_SQLiteNetExtensionsAsync_dll, 12800}, 4774};
extern const unsigned char assembly_data_SQLitePCLRaw_batteries_green_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_batteries_green_dll = {{"SQLitePCLRaw.batteries_green.dll", assembly_data_SQLitePCLRaw_batteries_green_dll, 5120}, 1886};
extern const unsigned char assembly_data_SQLitePCLRaw_batteries_v2_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_batteries_v2_dll = {{"SQLitePCLRaw.batteries_v2.dll", assembly_data_SQLitePCLRaw_batteries_v2_dll, 5120}, 1904};
extern const unsigned char assembly_data_SQLitePCLRaw_core_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_core_dll = {{"SQLitePCLRaw.core.dll", assembly_data_SQLitePCLRaw_core_dll, 37376}, 12760};
extern const unsigned char assembly_data_SQLitePCLRaw_lib_e_sqlite3_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_lib_e_sqlite3_dll = {{"SQLitePCLRaw.lib.e_sqlite3.dll", assembly_data_SQLitePCLRaw_lib_e_sqlite3_dll, 4608}, 1815};
extern const unsigned char assembly_data_SQLitePCLRaw_provider_e_sqlite3_dll [];
static CompressedAssembly assembly_bundle_SQLitePCLRaw_provider_e_sqlite3_dll = {{"SQLitePCLRaw.provider.e_sqlite3.dll", assembly_data_SQLitePCLRaw_provider_e_sqlite3_dll, 38400}, 14948};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Core_Common_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Core_Common_dll = {{"Xamarin.Android.Arch.Core.Common.dll", assembly_data_Xamarin_Android_Arch_Core_Common_dll, 17920}, 6131};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Lifecycle_Common_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Lifecycle_Common_dll = {{"Xamarin.Android.Arch.Lifecycle.Common.dll", assembly_data_Xamarin_Android_Arch_Lifecycle_Common_dll, 19456}, 6619};
extern const unsigned char assembly_data_Xamarin_Android_Arch_Lifecycle_Runtime_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Arch_Lifecycle_Runtime_dll = {{"Xamarin.Android.Arch.Lifecycle.Runtime.dll", assembly_data_Xamarin_Android_Arch_Lifecycle_Runtime_dll, 13824}, 4964};
extern const unsigned char assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll = {{"Xamarin.Android.Support.Animated.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Animated_Vector_Drawable_dll, 33280}, 9795};
extern const unsigned char assembly_data_Xamarin_Android_Support_Annotations_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Annotations_dll = {{"Xamarin.Android.Support.Annotations.dll", assembly_data_Xamarin_Android_Support_Annotations_dll, 110080}, 28977};
extern const unsigned char assembly_data_Xamarin_Android_Support_Compat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Compat_dll = {{"Xamarin.Android.Support.Compat.dll", assembly_data_Xamarin_Android_Support_Compat_dll, 1408512}, 316728};
extern const unsigned char assembly_data_Xamarin_Android_Support_Core_UI_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Core_UI_dll = {{"Xamarin.Android.Support.Core.UI.dll", assembly_data_Xamarin_Android_Support_Core_UI_dll, 349696}, 88460};
extern const unsigned char assembly_data_Xamarin_Android_Support_Core_Utils_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Core_Utils_dll = {{"Xamarin.Android.Support.Core.Utils.dll", assembly_data_Xamarin_Android_Support_Core_Utils_dll, 134144}, 37420};
extern const unsigned char assembly_data_Xamarin_Android_Support_Design_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Design_dll = {{"Xamarin.Android.Support.Design.dll", assembly_data_Xamarin_Android_Support_Design_dll, 403968}, 91755};
extern const unsigned char assembly_data_Xamarin_Android_Support_Fragment_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Fragment_dll = {{"Xamarin.Android.Support.Fragment.dll", assembly_data_Xamarin_Android_Support_Fragment_dll, 237568}, 58023};
extern const unsigned char assembly_data_Xamarin_Android_Support_Media_Compat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Media_Compat_dll = {{"Xamarin.Android.Support.Media.Compat.dll", assembly_data_Xamarin_Android_Support_Media_Compat_dll, 432128}, 99575};
extern const unsigned char assembly_data_Xamarin_Android_Support_Transition_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Transition_dll = {{"Xamarin.Android.Support.Transition.dll", assembly_data_Xamarin_Android_Support_Transition_dll, 131072}, 31519};
extern const unsigned char assembly_data_Xamarin_Android_Support_v4_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v4_dll = {{"Xamarin.Android.Support.v4.dll", assembly_data_Xamarin_Android_Support_v4_dll, 30208}, 9365};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_AppCompat_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll = {{"Xamarin.Android.Support.v7.AppCompat.dll", assembly_data_Xamarin_Android_Support_v7_AppCompat_dll, 1071616}, 248914};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_CardView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_CardView_dll = {{"Xamarin.Android.Support.v7.CardView.dll", assembly_data_Xamarin_Android_Support_v7_CardView_dll, 30720}, 9670};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll = {{"Xamarin.Android.Support.v7.MediaRouter.dll", assembly_data_Xamarin_Android_Support_v7_MediaRouter_dll, 194048}, 46620};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_Palette_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_Palette_dll = {{"Xamarin.Android.Support.v7.Palette.dll", assembly_data_Xamarin_Android_Support_v7_Palette_dll, 35840}, 10820};
extern const unsigned char assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll = {{"Xamarin.Android.Support.v7.RecyclerView.dll", assembly_data_Xamarin_Android_Support_v7_RecyclerView_dll, 554496}, 121610};
extern const unsigned char assembly_data_Xamarin_Android_Support_Vector_Drawable_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll = {{"Xamarin.Android.Support.Vector.Drawable.dll", assembly_data_Xamarin_Android_Support_Vector_Drawable_dll, 22528}, 7927};
extern const unsigned char assembly_data_Xamarin_Forms_Core_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Core_dll = {{"Xamarin.Forms.Core.dll", assembly_data_Xamarin_Forms_Core_dll, 565760}, 219618};
extern const unsigned char assembly_data_Xamarin_Forms_Maps_Android_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Maps_Android_dll = {{"Xamarin.Forms.Maps.Android.dll", assembly_data_Xamarin_Forms_Maps_Android_dll, 24648}, 12842};
extern const unsigned char assembly_data_Xamarin_Forms_Maps_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Maps_dll = {{"Xamarin.Forms.Maps.dll", assembly_data_Xamarin_Forms_Maps_dll, 14336}, 6339};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_Android_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_Android_dll = {{"Xamarin.Forms.Platform.Android.dll", assembly_data_Xamarin_Forms_Platform_Android_dll, 310864}, 134268};
extern const unsigned char assembly_data_Xamarin_Forms_Platform_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Platform_dll = {{"Xamarin.Forms.Platform.dll", assembly_data_Xamarin_Forms_Platform_dll, 16960}, 7039};
extern const unsigned char assembly_data_Xamarin_Forms_Xaml_dll [];
static CompressedAssembly assembly_bundle_Xamarin_Forms_Xaml_dll = {{"Xamarin.Forms.Xaml.dll", assembly_data_Xamarin_Forms_Xaml_dll, 73216}, 31645};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Base_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Base_dll = {{"Xamarin.GooglePlayServices.Base.dll", assembly_data_Xamarin_GooglePlayServices_Base_dll, 184832}, 48084};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Basement_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Basement_dll = {{"Xamarin.GooglePlayServices.Basement.dll", assembly_data_Xamarin_GooglePlayServices_Basement_dll, 113152}, 32605};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Maps_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Maps_dll = {{"Xamarin.GooglePlayServices.Maps.dll", assembly_data_Xamarin_GooglePlayServices_Maps_dll, 350208}, 83168};
extern const unsigned char assembly_data_Xamarin_GooglePlayServices_Tasks_dll [];
static CompressedAssembly assembly_bundle_Xamarin_GooglePlayServices_Tasks_dll = {{"Xamarin.GooglePlayServices.Tasks.dll", assembly_data_Xamarin_GooglePlayServices_Tasks_dll, 46592}, 12720};
extern const unsigned char assembly_data_Java_Interop_dll [];
static CompressedAssembly assembly_bundle_Java_Interop_dll = {{"Java.Interop.dll", assembly_data_Java_Interop_dll, 83456}, 25638};
extern const unsigned char assembly_data_Microsoft_CSharp_dll [];
static CompressedAssembly assembly_bundle_Microsoft_CSharp_dll = {{"Microsoft.CSharp.dll", assembly_data_Microsoft_CSharp_dll, 423936}, 160883};
extern const unsigned char assembly_data_Mono_Android_dll [];
static CompressedAssembly assembly_bundle_Mono_Android_dll = {{"Mono.Android.dll", assembly_data_Mono_Android_dll, 1477120}, 378033};
extern const unsigned char assembly_data_Mono_Android_Export_dll [];
static CompressedAssembly assembly_bundle_Mono_Android_Export_dll = {{"Mono.Android.Export.dll", assembly_data_Mono_Android_Export_dll, 76344}, 32014};
extern const unsigned char assembly_data_mscorlib_dll [];
static CompressedAssembly assembly_bundle_mscorlib_dll = {{"mscorlib.dll", assembly_data_mscorlib_dll, 2171904}, 756705};
extern const unsigned char assembly_data_System_Core_dll [];
static CompressedAssembly assembly_bundle_System_Core_dll = {{"System.Core.dll", assembly_data_System_Core_dll, 991232}, 338035};
extern const unsigned char assembly_data_System_dll [];
static CompressedAssembly assembly_bundle_System_dll = {{"System.dll", assembly_data_System_dll, 717312}, 292852};
extern const unsigned char assembly_data_System_Net_Http_dll [];
static CompressedAssembly assembly_bundle_System_Net_Http_dll = {{"System.Net.Http.dll", assembly_data_System_Net_Http_dll, 73216}, 32612};
extern const unsigned char assembly_data_System_Xml_dll [];
static CompressedAssembly assembly_bundle_System_Xml_dll = {{"System.Xml.dll", assembly_data_System_Xml_dll, 988160}, 358741};
extern const unsigned char assembly_data_System_Xml_Linq_dll [];
static CompressedAssembly assembly_bundle_System_Xml_Linq_dll = {{"System.Xml.Linq.dll", assembly_data_System_Xml_Linq_dll, 57344}, 23799};
extern const unsigned char assembly_data_System_Runtime_Serialization_dll [];
static CompressedAssembly assembly_bundle_System_Runtime_Serialization_dll = {{"System.Runtime.Serialization.dll", assembly_data_System_Runtime_Serialization_dll, 407552}, 152004};
extern const unsigned char assembly_data_System_ServiceModel_Internals_dll [];
static CompressedAssembly assembly_bundle_System_ServiceModel_Internals_dll = {{"System.ServiceModel.Internals.dll", assembly_data_System_ServiceModel_Internals_dll, 55808}, 20978};
extern const unsigned char assembly_data_System_Numerics_dll [];
static CompressedAssembly assembly_bundle_System_Numerics_dll = {{"System.Numerics.dll", assembly_data_System_Numerics_dll, 33280}, 15322};
extern const unsigned char assembly_data_Mono_Security_dll [];
static CompressedAssembly assembly_bundle_Mono_Security_dll = {{"Mono.Security.dll", assembly_data_Mono_Security_dll, 173568}, 74241};

static const CompressedAssembly *compressed [] = {
	&assembly_bundle_HAIS_DailyFuel_APP_Android_dll,
	&assembly_bundle_Behaviors_dll,
	&assembly_bundle_FormsViewGroup_dll,
	&assembly_bundle_Newtonsoft_Json_dll,
	&assembly_bundle_Plugin_CurrentActivity_dll,
	&assembly_bundle_Plugin_Geolocator_Abstractions_dll,
	&assembly_bundle_Plugin_Geolocator_dll,
	&assembly_bundle_Plugin_Permissions_Abstractions_dll,
	&assembly_bundle_Plugin_Permissions_dll,
	&assembly_bundle_SQLite_net_dll,
	&assembly_bundle_SQLite_Net_Async_dll,
	&assembly_bundle_SQLite_Net_dll,
	&assembly_bundle_SQLite_Net_Platform_XamarinAndroid_dll,
	&assembly_bundle_SQLiteNetExtensions_dll,
	&assembly_bundle_SQLiteNetExtensionsAsync_dll,
	&assembly_bundle_SQLitePCLRaw_batteries_green_dll,
	&assembly_bundle_SQLitePCLRaw_batteries_v2_dll,
	&assembly_bundle_SQLitePCLRaw_core_dll,
	&assembly_bundle_SQLitePCLRaw_lib_e_sqlite3_dll,
	&assembly_bundle_SQLitePCLRaw_provider_e_sqlite3_dll,
	&assembly_bundle_Xamarin_Android_Arch_Core_Common_dll,
	&assembly_bundle_Xamarin_Android_Arch_Lifecycle_Common_dll,
	&assembly_bundle_Xamarin_Android_Arch_Lifecycle_Runtime_dll,
	&assembly_bundle_Xamarin_Android_Support_Animated_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Android_Support_Annotations_dll,
	&assembly_bundle_Xamarin_Android_Support_Compat_dll,
	&assembly_bundle_Xamarin_Android_Support_Core_UI_dll,
	&assembly_bundle_Xamarin_Android_Support_Core_Utils_dll,
	&assembly_bundle_Xamarin_Android_Support_Design_dll,
	&assembly_bundle_Xamarin_Android_Support_Fragment_dll,
	&assembly_bundle_Xamarin_Android_Support_Media_Compat_dll,
	&assembly_bundle_Xamarin_Android_Support_Transition_dll,
	&assembly_bundle_Xamarin_Android_Support_v4_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_AppCompat_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_CardView_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_MediaRouter_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_Palette_dll,
	&assembly_bundle_Xamarin_Android_Support_v7_RecyclerView_dll,
	&assembly_bundle_Xamarin_Android_Support_Vector_Drawable_dll,
	&assembly_bundle_Xamarin_Forms_Core_dll,
	&assembly_bundle_Xamarin_Forms_Maps_Android_dll,
	&assembly_bundle_Xamarin_Forms_Maps_dll,
	&assembly_bundle_Xamarin_Forms_Platform_Android_dll,
	&assembly_bundle_Xamarin_Forms_Platform_dll,
	&assembly_bundle_Xamarin_Forms_Xaml_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Base_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Basement_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Maps_dll,
	&assembly_bundle_Xamarin_GooglePlayServices_Tasks_dll,
	&assembly_bundle_Java_Interop_dll,
	&assembly_bundle_Microsoft_CSharp_dll,
	&assembly_bundle_Mono_Android_dll,
	&assembly_bundle_Mono_Android_Export_dll,
	&assembly_bundle_mscorlib_dll,
	&assembly_bundle_System_Core_dll,
	&assembly_bundle_System_dll,
	&assembly_bundle_System_Net_Http_dll,
	&assembly_bundle_System_Xml_dll,
	&assembly_bundle_System_Xml_Linq_dll,
	&assembly_bundle_System_Runtime_Serialization_dll,
	&assembly_bundle_System_ServiceModel_Internals_dll,
	&assembly_bundle_System_Numerics_dll,
	&assembly_bundle_Mono_Security_dll,
	NULL
};

static char *image_name = "HAIS.DailyFuel.APP.Android.dll";

static void install_dll_config_files (void (register_config_for_assembly_func)(const char *, const char *)) {

	register_config_for_assembly_func ("HAIS.DailyFuel.APP.Android.dll", assembly_config_HAIS_DailyFuel_APP_Android_dll);

}

static const char *config_dir = NULL;
static MonoBundledAssembly **bundled;

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <zlib.h>

static int
my_inflate (const Byte *compr, uLong compr_len, Byte *uncompr, uLong uncompr_len)
{
	int err;
	z_stream stream;

	memset (&stream, 0, sizeof (z_stream));
	stream.next_in = (Byte *) compr;
	stream.avail_in = (uInt) compr_len;

	// http://www.zlib.net/manual.html
	err = inflateInit2 (&stream, 16+MAX_WBITS);
	if (err != Z_OK)
		return 1;

	for (;;) {
		stream.next_out = uncompr;
		stream.avail_out = (uInt) uncompr_len;
		err = inflate (&stream, Z_NO_FLUSH);
		if (err == Z_STREAM_END) break;
		if (err != Z_OK) {
			printf ("%d\n", err);
			return 2;
		}
	}

	err = inflateEnd (&stream);
	if (err != Z_OK)
		return 3;

	if (stream.total_out != uncompr_len)
		return 4;
	
	return 0;
}

void mono_mkbundle_init (void (register_bundled_assemblies_func)(const MonoBundledAssembly **), void (register_config_for_assembly_func)(const char *, const char *))
{
	CompressedAssembly **ptr;
	MonoBundledAssembly **bundled_ptr;
	Bytef *buffer;
	int nbundles;

	install_dll_config_files (register_config_for_assembly_func);

	ptr = (CompressedAssembly **) compressed;
	nbundles = 0;
	while (*ptr++ != NULL)
		nbundles++;

	bundled = (MonoBundledAssembly **) malloc (sizeof (MonoBundledAssembly *) * (nbundles + 1));
	bundled_ptr = bundled;
	ptr = (CompressedAssembly **) compressed;
	while (*ptr != NULL) {
		uLong real_size;
		uLongf zsize;
		int result;
		MonoBundledAssembly *current;

		real_size = (*ptr)->assembly.size;
		zsize = (*ptr)->compressed_size;
		buffer = (Bytef *) malloc (real_size);
		result = my_inflate ((*ptr)->assembly.data, zsize, buffer, real_size);
		if (result != 0) {
			fprintf (stderr, "mkbundle: Error %d decompressing data for %s\n", result, (*ptr)->assembly.name);
			exit (1);
		}
		(*ptr)->assembly.data = buffer;
		current = (MonoBundledAssembly *) malloc (sizeof (MonoBundledAssembly));
		memcpy (current, *ptr, sizeof (MonoBundledAssembly));
		current->name = (*ptr)->assembly.name;
		*bundled_ptr = current;
		bundled_ptr++;
		ptr++;
	}
	*bundled_ptr = NULL;
	register_bundled_assemblies_func((const MonoBundledAssembly **) bundled);
}
