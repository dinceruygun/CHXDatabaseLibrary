using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXHttpRequest
{
    public enum CHXContentType
    {
        [CHXMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        AAB,

        [CHXMetadata(Value = "audio/x-aac", IsBinary = true)]
        AAC,

        [CHXMetadata(Value = "application/x-authorware-map", IsBinary = true)]
        AAM,

        [CHXMetadata(Value = "application/x-authorware-seg", IsBinary = true)]
        AAS,

        [CHXMetadata(Value = "application/x-abiword", IsBinary = true)]
        ABW,

        [CHXMetadata(Value = "application/pkix-attr-cert", IsBinary = true)]
        AC,

        [CHXMetadata(Value = "application/vnd.americandynamics.acc", IsBinary = true)]
        ACC,

        [CHXMetadata(Value = "application/x-ace-compressed", IsBinary = true)]
        ACE,

        [CHXMetadata(Value = "application/vnd.acucobol", IsBinary = true)]
        ACU,

        [CHXMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ACUTC,

        [CHXMetadata(Value = "audio/adpcm", IsBinary = true)]
        ADP,

        [CHXMetadata(Value = "application/vnd.audiograph", IsBinary = true)]
        AEP,

        [CHXMetadata(Value = "application/x-font-type1", IsBinary = true)]
        AFM,

        [CHXMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        AFP,

        [CHXMetadata(Value = "application/vnd.ahead.space", IsBinary = true)]
        AHEAD,

        [CHXMetadata(Value = "application/postscript", IsBinary = true)]
        AI,

        [CHXMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIF,

        [CHXMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFC,

        [CHXMetadata(Value = "audio/x-aiff", IsBinary = true)]
        AIFF,

        [CHXMetadata(Value = "application/vnd.adobe.air-application-installer-package+zip", IsBinary = true)]
        AIR,

        [CHXMetadata(Value = "application/vnd.dvb.ait", IsBinary = true)]
        AIT,

        [CHXMetadata(Value = "application/vnd.amiga.ami", IsBinary = true)]
        AMI,

        [CHXMetadata(Value = "application/vnd.android.package-archive", IsBinary = true)]
        APK,

        [CHXMetadata(Value = "text/cache-manifest", IsText = true)]
        APPCACHE,

        [CHXMetadata(Value = "application/x-ms-application", IsBinary = true)]
        APPLICATION,

        [CHXMetadata(Value = "application/vnd.lotus-approach", IsBinary = true)]
        APR,

        [CHXMetadata(Value = "application/x-freearc", IsBinary = true)]
        ARC,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        ASC,

        [CHXMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASF,

        [CHXMetadata(Value = "text/x-asm", IsText = true)]
        ASM,

        [CHXMetadata(Value = "application/vnd.accpac.simply.aso", IsBinary = true)]
        ASO,

        [CHXMetadata(Value = "video/x-ms-asf", IsBinary = true)]
        ASX,

        [CHXMetadata(Value = "application/vnd.acucorp", IsBinary = true)]
        ATC,

        [CHXMetadata(Value = "application/atom+xml", IsText = true)]
        ATOM,

        [CHXMetadata(Value = "application/atomcat+xml", IsText = true)]
        ATOMCAT,

        [CHXMetadata(Value = "application/atomsvc+xml", IsText = true)]
        ATOMSVC,

        [CHXMetadata(Value = "application/vnd.antix.game-component", IsBinary = true)]
        ATX,

        [CHXMetadata(Value = "audio/basic", IsBinary = true)]
        AU,

        [CHXMetadata(Value = "video/x-msvideo", IsBinary = true)]
        AVI,

        [CHXMetadata(Value = "application/applixware", IsBinary = true)]
        AW,

        [CHXMetadata(Value = "application/vnd.airzip.filesecure.azf", IsBinary = true)]
        AZF,

        [CHXMetadata(Value = "application/vnd.airzip.filesecure.azs", IsBinary = true)]
        AZS,

        [CHXMetadata(Value = "application/vnd.amazon.ebook", IsBinary = true)]
        AZW,

        [CHXMetadata(Value = "application/x-msdownload", IsBinary = true)]
        BAT,

        [CHXMetadata(Value = "application/x-bcpio", IsBinary = true)]
        BCPIO,

        [CHXMetadata(Value = "application/x-font-bdf", IsBinary = true)]
        BDF,

        [CHXMetadata(Value = "application/vnd.syncml.dm+wbxml", IsText = true)]
        BDM,

        [CHXMetadata(Value = "application/vnd.realvnc.bed", IsBinary = true)]
        BED,

        [CHXMetadata(Value = "application/vnd.fujitsu.oasysprs", IsBinary = true)]
        BH2,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        BIN,

        [CHXMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLB,

        [CHXMetadata(Value = "application/x-blorb", IsBinary = true)]
        BLORB,

        [CHXMetadata(Value = "application/vnd.bmi", IsBinary = true)]
        BMI,

        [CHXMetadata(Value = "image/bmp", IsBinary = true)]
        BMP,

        [CHXMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        BOOK,

        [CHXMetadata(Value = "application/vnd.previewsystems.box", IsBinary = true)]
        BOX,

        [CHXMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BOZ,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        BPK,

        [CHXMetadata(Value = "image/prs.btif", IsBinary = true)]
        BTIF,

        [CHXMetadata(Value = "application/x-bzip", IsBinary = true)]
        BZ,

        [CHXMetadata(Value = "application/x-bzip2", IsBinary = true)]
        BZ2,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        C,

        [CHXMetadata(Value = "application/vnd.cluetrust.cartomobile-config", IsBinary = true)]
        C11AMC,

        [CHXMetadata(Value = "application/vnd.cluetrust.cartomobile-config-pkg", IsBinary = true)]
        C11AMZ,

        [CHXMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4D,

        [CHXMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4F,

        [CHXMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4G,

        [CHXMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4P,

        [CHXMetadata(Value = "application/vnd.clonk.c4group", IsBinary = true)]
        C4U,

        [CHXMetadata(Value = "application/vnd.ms-cab-compressed", IsBinary = true)]
        CAB,

        [CHXMetadata(Value = "audio/x-caf", IsBinary = true)]
        CAF,

        [CHXMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        CAP,

        [CHXMetadata(Value = "application/vnd.curl.car", IsBinary = true)]
        CAR,

        [CHXMetadata(Value = "application/vnd.ms-pki.seccat", IsBinary = true)]
        CAT,

        [CHXMetadata(Value = "application/x-cbr", IsBinary = true)]
        CB7,

        [CHXMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBA,

        [CHXMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBR,

        [CHXMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBT,

        [CHXMetadata(Value = "application/x-cbr", IsBinary = true)]
        CBZ,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        CC,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        CCT,

        [CHXMetadata(Value = "application/ccxml+xml", IsText = true)]
        CCXML,

        [CHXMetadata(Value = "application/vnd.contact.cmsg", IsBinary = true)]
        CDBCMSG,

        [CHXMetadata(Value = "application/x-netcdf", IsBinary = true)]
        CDF,

        [CHXMetadata(Value = "application/vnd.mediastation.cdkey", IsBinary = true)]
        CDKEY,

        [CHXMetadata(Value = "application/cdmi-capability", IsBinary = true)]
        CDMIA,

        [CHXMetadata(Value = "application/cdmi-container", IsBinary = true)]
        CDMIC,

        [CHXMetadata(Value = "application/cdmi-domain", IsBinary = true)]
        CDMID,

        [CHXMetadata(Value = "application/cdmi-object", IsBinary = true)]
        CDMIO,

        [CHXMetadata(Value = "application/cdmi-queue", IsBinary = true)]
        CDMIQ,

        [CHXMetadata(Value = "chemical/x-cdx", IsBinary = true)]
        CDX,

        [CHXMetadata(Value = "application/vnd.chemdraw+xml", IsText = true)]
        CDXML,

        [CHXMetadata(Value = "application/vnd.cinderella", IsBinary = true)]
        CDY,

        [CHXMetadata(Value = "application/pkix-cert", IsBinary = true)]
        CER,

        [CHXMetadata(Value = "application/x-cfs-compressed", IsBinary = true)]
        CFS,

        [CHXMetadata(Value = "image/cgm", IsBinary = true)]
        CGM,

        [CHXMetadata(Value = "application/x-chat", IsBinary = true)]
        CHAT,

        [CHXMetadata(Value = "application/vnd.ms-htmlhelp", IsBinary = true)]
        CHM,

        [CHXMetadata(Value = "application/vnd.kde.kchart", IsBinary = true)]
        CHRT,

        [CHXMetadata(Value = "chemical/x-cif", IsBinary = true)]
        CIF,

        [CHXMetadata(Value = "application/vnd.anser-web-certificate-issue-initiation", IsBinary = true)]
        CII,

        [CHXMetadata(Value = "application/vnd.ms-artgalry", IsBinary = true)]
        CIL,

        [CHXMetadata(Value = "application/vnd.claymore", IsBinary = true)]
        CLA,

        [CHXMetadata(Value = "application/java-vm", IsBinary = true)]
        CLASS,

        [CHXMetadata(Value = "application/vnd.crick.clicker.keyboard", IsBinary = true)]
        CLKK,

        [CHXMetadata(Value = "application/vnd.crick.clicker.palette", IsBinary = true)]
        CLKP,

        [CHXMetadata(Value = "application/vnd.crick.clicker.template", IsBinary = true)]
        CLKT,

        [CHXMetadata(Value = "application/vnd.crick.clicker.wordbank", IsBinary = true)]
        CLKW,

        [CHXMetadata(Value = "application/vnd.crick.clicker", IsBinary = true)]
        CLKX,

        [CHXMetadata(Value = "application/x-msclip", IsBinary = true)]
        CLP,

        [CHXMetadata(Value = "application/vnd.cosmocaller", IsBinary = true)]
        CMC,

        [CHXMetadata(Value = "chemical/x-cmdf", IsBinary = true)]
        CMDF,

        [CHXMetadata(Value = "chemical/x-cml", IsBinary = true)]
        CML,

        [CHXMetadata(Value = "application/vnd.yellowriver-custom-menu", IsBinary = true)]
        CMP,

        [CHXMetadata(Value = "image/x-cmx", IsBinary = true)]
        CMX,

        [CHXMetadata(Value = "application/vnd.rim.cod", IsBinary = true)]
        COD,

        [CHXMetadata(Value = "application/x-msdownload", IsBinary = true)]
        COM,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        CONF,

        [CHXMetadata(Value = "application/x-cpio", IsBinary = true)]
        CPIO,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        CPP,

        [CHXMetadata(Value = "application/mac-compactpro", IsBinary = true)]
        CPT,

        [CHXMetadata(Value = "application/x-mscardfile", IsBinary = true)]
        CRD,

        [CHXMetadata(Value = "application/pkix-crl", IsBinary = true)]
        CRL,

        [CHXMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        CRT,

        [CHXMetadata(Value = "application/vnd.rig.cryptonote", IsBinary = true)]
        CRYPTONOTE,

        [CHXMetadata(Value = "application/x-csh", IsBinary = true)]
        CSH,

        [CHXMetadata(Value = "chemical/x-csml", IsBinary = true)]
        CSML,

        [CHXMetadata(Value = "application/vnd.commonspace", IsBinary = true)]
        CSP,

        [CHXMetadata(Value = "text/css", IsText = true)]
        CSS,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        CST,

        [CHXMetadata(Value = "text/csv", IsText = true)]
        CSV,

        [CHXMetadata(Value = "application/cu-seeme", IsBinary = true)]
        CU,

        [CHXMetadata(Value = "text/vnd.curl", IsText = true)]
        CURL,

        [CHXMetadata(Value = "application/prs.cww", IsBinary = true)]
        CWW,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        CXT,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        CXX,

        [CHXMetadata(Value = "model/vnd.collada+xml", IsText = true)]
        DAE,

        [CHXMetadata(Value = "application/vnd.mobius.daf", IsBinary = true)]
        DAF,

        [CHXMetadata(Value = "application/vnd.dart", IsBinary = true)]
        DART,

        [CHXMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        DATALESS,

        [CHXMetadata(Value = "application/davmount+xml", IsText = true)]
        DAVMOUNT,

        [CHXMetadata(Value = "application/docbook+xml", IsText = true)]
        DBK,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        DCR,

        [CHXMetadata(Value = "text/vnd.curl.dcurl", IsText = true)]
        DCURL,

        [CHXMetadata(Value = "application/vnd.oma.dd2+xml", IsText = true)]
        DD2,

        [CHXMetadata(Value = "application/vnd.fujixerox.ddd", IsBinary = true)]
        DDD,

        [CHXMetadata(Value = "application/x-debian-package", IsBinary = true)]
        DEB,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        DEF,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEPLOY,

        [CHXMetadata(Value = "application/x-x509-ca-cert", IsBinary = true)]
        DER,

        [CHXMetadata(Value = "application/vnd.dreamfactory", IsBinary = true)]
        DFAC,

        [CHXMetadata(Value = "application/x-dgc-compressed", IsBinary = true)]
        DGC,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        DIC,

        [CHXMetadata(Value = "video/x-dv", IsBinary = true)]
        DIF,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        DIR,

        [CHXMetadata(Value = "application/vnd.mobius.dis", IsBinary = true)]
        DIS,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DIST,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DISTZ,

        [CHXMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJV,

        [CHXMetadata(Value = "image/vnd.djvu", IsBinary = true)]
        DJVU,

        [CHXMetadata(Value = "application/x-msdownload", IsBinary = true)]
        DLL,

        [CHXMetadata(Value = "application/x-apple-diskimage", IsBinary = true)]
        DMG,

        [CHXMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        DMP,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DMS,

        [CHXMetadata(Value = "application/vnd.dna", IsBinary = true)]
        DNA,

        [CHXMetadata(Value = "application/msword", IsBinary = true)]
        DOC,

        [CHXMetadata(Value = "application/vnd.ms-word.document.macroenabled.12", IsBinary = true)]
        DOCM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.document", IsBinary = true)]
        DOCX,

        [CHXMetadata(Value = "application/msword", IsBinary = true)]
        DOT,

        [CHXMetadata(Value = "application/vnd.ms-word.template.macroenabled.12", IsBinary = true)]
        DOTM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.wordprocessingml.template", IsBinary = true)]
        DOTX,

        [CHXMetadata(Value = "application/vnd.osgi.dp", IsBinary = true)]
        DP,

        [CHXMetadata(Value = "application/vnd.dpgraph", IsBinary = true)]
        DPG,

        [CHXMetadata(Value = "audio/vnd.dra", IsBinary = true)]
        DRA,

        [CHXMetadata(Value = "text/prs.lines.tag", IsText = true)]
        DSC,

        [CHXMetadata(Value = "application/dssc+der", IsBinary = true)]
        DSSC,

        [CHXMetadata(Value = "application/x-dtbook+xml", IsText = true)]
        DTB,

        [CHXMetadata(Value = "application/xml-dtd", IsBinary = true)]
        DTD,

        [CHXMetadata(Value = "audio/vnd.dts", IsBinary = true)]
        DTS,

        [CHXMetadata(Value = "audio/vnd.dts.hd", IsBinary = true)]
        DTSHD,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DUMP,

        [CHXMetadata(Value = "video/x-dv", IsBinary = true)]
        DV,

        [CHXMetadata(Value = "video/vnd.dvb.file", IsBinary = true)]
        DVB,

        [CHXMetadata(Value = "application/x-dvi", IsBinary = true)]
        DVI,

        [CHXMetadata(Value = "model/vnd.dwf", IsBinary = true)]
        DWF,

        [CHXMetadata(Value = "image/vnd.dwg", IsBinary = true)]
        DWG,

        [CHXMetadata(Value = "image/vnd.dxf", IsBinary = true)]
        DXF,

        [CHXMetadata(Value = "application/vnd.spotfire.dxp", IsBinary = true)]
        DXP,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        DXR,

        [CHXMetadata(Value = "audio/vnd.nuera.ecelp4800", IsBinary = true)]
        ECELP4800,

        [CHXMetadata(Value = "audio/vnd.nuera.ecelp7470", IsBinary = true)]
        ECELP7470,

        [CHXMetadata(Value = "audio/vnd.nuera.ecelp9600", IsBinary = true)]
        ECELP9600,

        [CHXMetadata(Value = "application/ecmascript", IsBinary = true)]
        ECMA,

        [CHXMetadata(Value = "application/vnd.novadigm.edm", IsBinary = true)]
        EDM,

        [CHXMetadata(Value = "application/vnd.novadigm.edx", IsBinary = true)]
        EDX,

        [CHXMetadata(Value = "application/vnd.picsel", IsBinary = true)]
        EFIF,

        [CHXMetadata(Value = "application/vnd.pg.osasli", IsBinary = true)]
        EI6,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        ELC,

        [CHXMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMF,

        [CHXMetadata(Value = "message/rfc822", IsBinary = true)]
        EML,

        [CHXMetadata(Value = "application/emma+xml", IsText = true)]
        EMMA,

        [CHXMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        EMZ,

        [CHXMetadata(Value = "audio/vnd.digital-winds", IsBinary = true)]
        EOL,

        [CHXMetadata(Value = "application/vnd.ms-fontobject", IsBinary = true)]
        EOT,

        [CHXMetadata(Value = "application/postscript", IsBinary = true)]
        EPS,

        [CHXMetadata(Value = "application/epub+zip", IsBinary = true)]
        EPUB,

        [CHXMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ES3,

        [CHXMetadata(Value = "application/vnd.osgi.subsystem", IsBinary = true)]
        ESA,

        [CHXMetadata(Value = "application/vnd.epson.esf", IsBinary = true)]
        ESF,

        [CHXMetadata(Value = "application/vnd.eszigno3+xml", IsText = true)]
        ET3,

        [CHXMetadata(Value = "text/x-setext", IsText = true)]
        ETX,

        [CHXMetadata(Value = "application/x-eva", IsBinary = true)]
        EVA,

        [CHXMetadata(Value = "application/x-envoy", IsBinary = true)]
        EVY,

        [CHXMetadata(Value = "application/x-msdownload", IsBinary = true)]
        EXE,

        [CHXMetadata(Value = "application/exi", IsBinary = true)]
        EXI,

        [CHXMetadata(Value = "application/vnd.novadigm.ext", IsBinary = true)]
        EXT,

        [CHXMetadata(Value = "MIME type (lowercased)", IsBinary = true)]
        EXTENSIONS,

        [CHXMetadata(Value = "application/andrew-inset", IsBinary = true)]
        EZ,

        [CHXMetadata(Value = "application/vnd.ezpix-album", IsBinary = true)]
        EZ2,

        [CHXMetadata(Value = "application/vnd.ezpix-package", IsBinary = true)]
        EZ3,

        [CHXMetadata(Value = "text/x-fortran", IsText = true)]
        F,

        [CHXMetadata(Value = "video/x-f4v", IsBinary = true)]
        F4V,

        [CHXMetadata(Value = "text/x-fortran", IsText = true)]
        F77,

        [CHXMetadata(Value = "text/x-fortran", IsText = true)]
        F90,

        [CHXMetadata(Value = "image/vnd.fastbidsheet", IsBinary = true)]
        FBS,

        [CHXMetadata(Value = "application/vnd.adobe.formscentral.fcdt", IsBinary = true)]
        FCDT,

        [CHXMetadata(Value = "application/vnd.isac.fcs", IsBinary = true)]
        FCS,

        [CHXMetadata(Value = "application/vnd.fdf", IsBinary = true)]
        FDF,

        [CHXMetadata(Value = "application/vnd.denovo.fcselayout-link", IsBinary = true)]
        FE_LAUNCH,

        [CHXMetadata(Value = "application/vnd.fujitsu.oasysgp", IsBinary = true)]
        FG5,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        FGD,

        [CHXMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH,

        [CHXMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH4,

        [CHXMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH5,

        [CHXMetadata(Value = "image/x-freehand", IsBinary = true)]
        FH7,

        [CHXMetadata(Value = "image/x-freehand", IsBinary = true)]
        FHC,

        [CHXMetadata(Value = "application/x-xfig", IsBinary = true)]
        FIG,

        [CHXMetadata(Value = "audio/x-flac", IsBinary = true)]
        FLAC,

        [CHXMetadata(Value = "video/x-fli", IsBinary = true)]
        FLI,

        [CHXMetadata(Value = "application/vnd.micrografx.flo", IsBinary = true)]
        FLO,

        [CHXMetadata(Value = "video/x-flv", IsBinary = true)]
        FLV,

        [CHXMetadata(Value = "application/vnd.kde.kivio", IsBinary = true)]
        FLW,

        [CHXMetadata(Value = "text/vnd.fmi.flexstor", IsText = true)]
        FLX,

        [CHXMetadata(Value = "text/vnd.fly", IsText = true)]
        FLY,

        [CHXMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FM,

        [CHXMetadata(Value = "application/vnd.frogans.fnc", IsBinary = true)]
        FNC,

        [CHXMetadata(Value = "text/x-fortran", IsText = true)]
        FOR,

        [CHXMetadata(Value = "image/vnd.fpx", IsBinary = true)]
        FPX,

        [CHXMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        FRAME,

        [CHXMetadata(Value = "application/vnd.fsc.weblaunch", IsBinary = true)]
        FSC,

        [CHXMetadata(Value = "image/vnd.fst", IsBinary = true)]
        FST,

        [CHXMetadata(Value = "application/vnd.fluxtime.clip", IsBinary = true)]
        FTC,

        [CHXMetadata(Value = "application/vnd.anser-web-funds-transfer-initiation", IsBinary = true)]
        FTI,

        [CHXMetadata(Value = "video/vnd.fvt", IsBinary = true)]
        FVT,

        [CHXMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXP,

        [CHXMetadata(Value = "application/vnd.adobe.fxp", IsBinary = true)]
        FXPL,

        [CHXMetadata(Value = "application/vnd.fuzzysheet", IsBinary = true)]
        FZS,

        [CHXMetadata(Value = "application/vnd.geoplan", IsBinary = true)]
        G2W,

        [CHXMetadata(Value = "image/g3fax", IsBinary = true)]
        G3,

        [CHXMetadata(Value = "application/vnd.geospace", IsBinary = true)]
        G3W,

        [CHXMetadata(Value = "application/vnd.groove-account", IsBinary = true)]
        GAC,

        [CHXMetadata(Value = "application/x-tads", IsBinary = true)]
        GAM,

        [CHXMetadata(Value = "application/rpki-ghostbusters", IsBinary = true)]
        GBR,

        [CHXMetadata(Value = "application/x-gca-compressed", IsBinary = true)]
        GCA,

        [CHXMetadata(Value = "model/vnd.gdl", IsBinary = true)]
        GDL,

        [CHXMetadata(Value = "application/vnd.dynageo", IsBinary = true)]
        GEO,

        [CHXMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GEX,

        [CHXMetadata(Value = "application/vnd.geogebra.file", IsBinary = true)]
        GGB,

        [CHXMetadata(Value = "application/vnd.geogebra.tool", IsBinary = true)]
        GGT,

        [CHXMetadata(Value = "application/vnd.groove-help", IsBinary = true)]
        GHF,

        [CHXMetadata(Value = "image/gif", IsBinary = true)]
        GIF,

        [CHXMetadata(Value = "application/vnd.groove-identity-message", IsBinary = true)]
        GIM,

        [CHXMetadata(Value = "application/gml+xml", IsText = true)]
        GML,

        [CHXMetadata(Value = "application/vnd.gmx", IsBinary = true)]
        GMX,

        [CHXMetadata(Value = "application/x-gnumeric", IsBinary = true)]
        GNUMERIC,

        [CHXMetadata(Value = "application/vnd.flographit", IsBinary = true)]
        GPH,

        [CHXMetadata(Value = "application/gpx+xml", IsText = true)]
        GPX,

        [CHXMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQF,

        [CHXMetadata(Value = "application/vnd.grafeq", IsBinary = true)]
        GQS,

        [CHXMetadata(Value = "application/srgs", IsBinary = true)]
        GRAM,

        [CHXMetadata(Value = "application/x-gramps-xml", IsText = true)]
        GRAMPS,

        [CHXMetadata(Value = "application/vnd.geometry-explorer", IsBinary = true)]
        GRE,

        [CHXMetadata(Value = "application/vnd.groove-injector", IsBinary = true)]
        GRV,

        [CHXMetadata(Value = "application/srgs+xml", IsText = true)]
        GRXML,

        [CHXMetadata(Value = "application/x-font-ghostscript", IsBinary = true)]
        GSF,

        [CHXMetadata(Value = "application/x-gtar", IsBinary = true)]
        GTAR,

        [CHXMetadata(Value = "application/vnd.groove-tool-message", IsBinary = true)]
        GTM,

        [CHXMetadata(Value = "model/vnd.gtw", IsBinary = true)]
        GTW,

        [CHXMetadata(Value = "text/vnd.graphviz", IsText = true)]
        GV,

        [CHXMetadata(Value = "application/gxf", IsBinary = true)]
        GXF,

        [CHXMetadata(Value = "application/vnd.geonext", IsBinary = true)]
        GXT,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        H,

        [CHXMetadata(Value = "video/h261", IsBinary = true)]
        H261,

        [CHXMetadata(Value = "video/h263", IsBinary = true)]
        H263,

        [CHXMetadata(Value = "video/h264", IsBinary = true)]
        H264,

        [CHXMetadata(Value = "application/vnd.hal+xml", IsText = true)]
        HAL,

        [CHXMetadata(Value = "application/vnd.hbci", IsBinary = true)]
        HBCI,

        [CHXMetadata(Value = "application/x-hdf", IsBinary = true)]
        HDF,

        [CHXMetadata(Value = "text/x-c", IsText = true)]
        HH,

        [CHXMetadata(Value = "application/winhlp", IsBinary = true)]
        HLP,

        [CHXMetadata(Value = "application/vnd.hp-hpgl", IsBinary = true)]
        HPGL,

        [CHXMetadata(Value = "application/vnd.hp-hpid", IsBinary = true)]
        HPID,

        [CHXMetadata(Value = "application/vnd.hp-hps", IsBinary = true)]
        HPS,

        [CHXMetadata(Value = "application/mac-binhex40", IsBinary = true)]
        HQX,

        [CHXMetadata(Value = "application/vnd.kenameaapp", IsBinary = true)]
        HTKE,

        [CHXMetadata(Value = "text/html", IsText = true)]
        HTM,

        [CHXMetadata(Value = "text/html", IsText = true)]
        HTML,

        [CHXMetadata(Value = "application/vnd.yamaha.hv-dic", IsBinary = true)]
        HVD,

        [CHXMetadata(Value = "application/vnd.yamaha.hv-voice", IsBinary = true)]
        HVP,

        [CHXMetadata(Value = "application/vnd.yamaha.hv-script", IsBinary = true)]
        HVS,

        [CHXMetadata(Value = "application/vnd.intergeo", IsBinary = true)]
        I2G,

        [CHXMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        IC,

        [CHXMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICC,

        [CHXMetadata(Value = "x-conference/x-cooltalk", IsBinary = true)]
        ICE,

        [CHXMetadata(Value = "application/vnd.iccprofile", IsBinary = true)]
        ICM,

        [CHXMetadata(Value = "image/x-icon", IsBinary = true)]
        ICO,

        [CHXMetadata(Value = "text/calendar", IsText = true)]
        ICS,

        [CHXMetadata(Value = "image/ief", IsBinary = true)]
        IEF,

        [CHXMetadata(Value = "text/calendar", IsText = true)]
        IFB,

        [CHXMetadata(Value = "application/vnd.shana.informed.formdata", IsBinary = true)]
        IFM,

        [CHXMetadata(Value = "model/iges", IsBinary = true)]
        IGES,

        [CHXMetadata(Value = "application/vnd.igloader", IsBinary = true)]
        IGL,

        [CHXMetadata(Value = "application/vnd.insors.igm", IsBinary = true)]
        IGM,

        [CHXMetadata(Value = "model/iges", IsBinary = true)]
        IGS,

        [CHXMetadata(Value = "application/vnd.micrografx.igx", IsBinary = true)]
        IGX,

        [CHXMetadata(Value = "application/vnd.shana.informed.interchange", IsBinary = true)]
        IIF,

        [CHXMetadata(Value = "application/vnd.accpac.simply.imp", IsBinary = true)]
        IMP,

        [CHXMetadata(Value = "application/vnd.ms-ims", IsBinary = true)]
        IMS,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        IN,

        [CHXMetadata(Value = "application/inkml+xml", IsText = true)]
        INK,

        [CHXMetadata(Value = "application/inkml+xml", IsText = true)]
        INKML,

        [CHXMetadata(Value = "application/x-install-instructions", IsBinary = true)]
        INSTALL,

        [CHXMetadata(Value = "application/vnd.astraea-software.iota", IsBinary = true)]
        IOTA,

        [CHXMetadata(Value = "application/ipfix", IsBinary = true)]
        IPFIX,

        [CHXMetadata(Value = "application/vnd.shana.informed.package", IsBinary = true)]
        IPK,

        [CHXMetadata(Value = "application/vnd.ibm.rights-management", IsBinary = true)]
        IRM,

        [CHXMetadata(Value = "application/vnd.irepository.package+xml", IsText = true)]
        IRP,

        [CHXMetadata(Value = "application/x-iso9660-image", IsBinary = true)]
        ISO,

        [CHXMetadata(Value = "application/vnd.shana.informed.formtemplate", IsBinary = true)]
        ITP,

        [CHXMetadata(Value = "application/vnd.immervision-ivp", IsBinary = true)]
        IVP,

        [CHXMetadata(Value = "application/vnd.immervision-ivu", IsBinary = true)]
        IVU,

        [CHXMetadata(Value = "text/vnd.sun.j2me.app-descriptor", IsText = true)]
        JAD,

        [CHXMetadata(Value = "application/vnd.jam", IsBinary = true)]
        JAM,

        [CHXMetadata(Value = "application/java-archive", IsBinary = true)]
        JAR,

        [CHXMetadata(Value = "text/x-java-source", IsText = true)]
        JAVA,

        [CHXMetadata(Value = "application/vnd.jisp", IsBinary = true)]
        JISP,

        [CHXMetadata(Value = "application/vnd.hp-jlyt", IsBinary = true)]
        JLT,

        [CHXMetadata(Value = "application/x-java-jnlp-file", IsBinary = true)]
        JNLP,

        [CHXMetadata(Value = "application/vnd.joost.joda-archive", IsBinary = true)]
        JODA,

        [CHXMetadata(Value = "image/jp2", IsBinary = true)]
        JP2,

        [CHXMetadata(Value = "image/jpeg", IsBinary = true)]
        JPE,

        [CHXMetadata(Value = "image/jpeg", IsBinary = true)]
        JPEG,

        [CHXMetadata(Value = "image/jpeg", IsBinary = true)]
        JPG,

        [CHXMetadata(Value = "video/jpm", IsBinary = true)]
        JPGM,

        [CHXMetadata(Value = "video/jpeg", IsBinary = true)]
        JPGV,

        [CHXMetadata(Value = "video/jpm", IsBinary = true)]
        JPM,

        [CHXMetadata(Value = "application/javascript", IsText = true)]
        JS,

        [CHXMetadata(Value = "application/json", IsText = true)]
        JSON,

        [CHXMetadata(Value = "application/jsonml+json", IsText = true)]
        JSONML,

        [CHXMetadata(Value = "audio/midi", IsBinary = true)]
        KAR,

        [CHXMetadata(Value = "application/vnd.kde.karbon", IsBinary = true)]
        KARBON,

        [CHXMetadata(Value = "application/vnd.kde.kformula", IsBinary = true)]
        KFO,

        [CHXMetadata(Value = "application/vnd.kidspiration", IsBinary = true)]
        KIA,

        [CHXMetadata(Value = "application/vnd.google-earth.kml+xml", IsText = true)]
        KML,

        [CHXMetadata(Value = "application/vnd.google-earth.kmz", IsBinary = true)]
        KMZ,

        [CHXMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNE,

        [CHXMetadata(Value = "application/vnd.kinar", IsBinary = true)]
        KNP,

        [CHXMetadata(Value = "application/vnd.kde.kontour", IsBinary = true)]
        KON,

        [CHXMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPR,

        [CHXMetadata(Value = "application/vnd.kde.kpresenter", IsBinary = true)]
        KPT,

        [CHXMetadata(Value = "application/vnd.ds-keypoint", IsBinary = true)]
        KPXX,

        [CHXMetadata(Value = "application/vnd.kde.kspread", IsBinary = true)]
        KSP,

        [CHXMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTR,

        [CHXMetadata(Value = "image/ktx", IsBinary = true)]
        KTX,

        [CHXMetadata(Value = "application/vnd.kahootz", IsBinary = true)]
        KTZ,

        [CHXMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWD,

        [CHXMetadata(Value = "application/vnd.kde.kword", IsBinary = true)]
        KWT,

        [CHXMetadata(Value = "application/vnd.las.las+xml", IsText = true)]
        LASXML,

        [CHXMetadata(Value = "application/x-latex", IsBinary = true)]
        LATEX,

        [CHXMetadata(Value = "application/vnd.llamagraphics.life-balance.desktop", IsBinary = true)]
        LBD,

        [CHXMetadata(Value = "application/vnd.llamagraphics.life-balance.exchange+xml", IsText = true)]
        LBE,

        [CHXMetadata(Value = "application/vnd.hhe.lesson-player", IsBinary = true)]
        LES,

        [CHXMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LHA,

        [CHXMetadata(Value = "application/vnd.route66.link66+xml", IsText = true)]
        LINK66,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        LIST,

        [CHXMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LIST3820,

        [CHXMetadata(Value = "application/vnd.ibm.modcap", IsBinary = true)]
        LISTAFP,

        [CHXMetadata(Value = "application/x-ms-shortcut", IsBinary = true)]
        LNK,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        LOG,

        [CHXMetadata(Value = "application/lost+xml", IsText = true)]
        LOSTXML,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        LRF,

        [CHXMetadata(Value = "application/vnd.ms-lrm", IsBinary = true)]
        LRM,

        [CHXMetadata(Value = "application/vnd.frogans.ltf", IsBinary = true)]
        LTF,

        [CHXMetadata(Value = "audio/vnd.lucent.voice", IsBinary = true)]
        LVP,

        [CHXMetadata(Value = "application/vnd.lotus-wordpro", IsBinary = true)]
        LWP,

        [CHXMetadata(Value = "application/x-lzh-compressed", IsBinary = true)]
        LZH,

        [CHXMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M13,

        [CHXMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        M14,

        [CHXMetadata(Value = "video/mpeg", IsBinary = true)]
        M1V,

        [CHXMetadata(Value = "application/mp21", IsBinary = true)]
        M21,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        M2A,

        [CHXMetadata(Value = "video/mpeg", IsBinary = true)]
        M2V,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        M3A,

        [CHXMetadata(Value = "audio/x-mpegurl", IsBinary = true)]
        M3U,

        [CHXMetadata(Value = "application/vnd.apple.mpegurl", IsBinary = true)]
        M3U8,

        [CHXMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4A,

        [CHXMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4B,

        [CHXMetadata(Value = "audio/mp4a-latm", IsBinary = true)]
        M4P,

        [CHXMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        M4U,

        [CHXMetadata(Value = "video/x-m4v", IsBinary = true)]
        M4V,

        [CHXMetadata(Value = "application/mathematica", IsBinary = true)]
        MA,

        [CHXMetadata(Value = "image/x-macpaint", IsBinary = true)]
        MAC,

        [CHXMetadata(Value = "application/mads+xml", IsText = true)]
        MADS,

        [CHXMetadata(Value = "application/vnd.ecowin.chart", IsBinary = true)]
        MAG,

        [CHXMetadata(Value = "application/vnd.framemaker", IsBinary = true)]
        MAKER,

        [CHXMetadata(Value = "application/x-troff-man", IsBinary = true)]
        MAN,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        MAR,

        [CHXMetadata(Value = "application/mathml+xml", IsText = true)]
        MATHML,

        [CHXMetadata(Value = "application/mathematica", IsBinary = true)]
        MB,

        [CHXMetadata(Value = "application/vnd.mobius.mbk", IsBinary = true)]
        MBK,

        [CHXMetadata(Value = "application/mbox", IsBinary = true)]
        MBOX,

        [CHXMetadata(Value = "application/vnd.medcalcdata", IsBinary = true)]
        MC1,

        [CHXMetadata(Value = "application/vnd.mcd", IsBinary = true)]
        MCD,

        [CHXMetadata(Value = "text/vnd.curl.mcurl", IsText = true)]
        MCURL,

        [CHXMetadata(Value = "application/x-msaccess", IsBinary = true)]
        MDB,

        [CHXMetadata(Value = "image/vnd.ms-modi", IsBinary = true)]
        MDI,

        [CHXMetadata(Value = "application/x-troff-me", IsBinary = true)]
        ME,

        [CHXMetadata(Value = "model/mesh", IsBinary = true)]
        MESH,

        [CHXMetadata(Value = "application/metalink4+xml", IsText = true)]
        META4,

        [CHXMetadata(Value = "application/metalink+xml", IsText = true)]
        METALINK,

        [CHXMetadata(Value = "application/mets+xml", IsText = true)]
        METS,

        [CHXMetadata(Value = "application/vnd.mfmp", IsBinary = true)]
        MFM,

        [CHXMetadata(Value = "application/rpki-manifest", IsBinary = true)]
        MFT,

        [CHXMetadata(Value = "application/vnd.osgeo.mapguide.package", IsBinary = true)]
        MGP,

        [CHXMetadata(Value = "application/vnd.proteus.magazine", IsBinary = true)]
        MGZ,

        [CHXMetadata(Value = "audio/midi", IsBinary = true)]
        MID,

        [CHXMetadata(Value = "audio/midi", IsBinary = true)]
        MIDI,

        [CHXMetadata(Value = "application/x-mie", IsBinary = true)]
        MIE,

        [CHXMetadata(Value = "application/vnd.mif", IsBinary = true)]
        MIF,

        [CHXMetadata(Value = "message/rfc822", IsBinary = true)]
        MIME,

        [CHXMetadata(Value = "video/mj2", IsBinary = true)]
        MJ2,

        [CHXMetadata(Value = "video/mj2", IsBinary = true)]
        MJP2,

        [CHXMetadata(Value = "video/x-matroska", IsBinary = true)]
        MK3D,

        [CHXMetadata(Value = "audio/x-matroska", IsBinary = true)]
        MKA,

        [CHXMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKS,

        [CHXMetadata(Value = "video/x-matroska", IsBinary = true)]
        MKV,

        [CHXMetadata(Value = "application/vnd.dolby.mlp", IsBinary = true)]
        MLP,

        [CHXMetadata(Value = "application/vnd.chipnuts.karaoke-mmd", IsBinary = true)]
        MMD,

        [CHXMetadata(Value = "application/vnd.smaf", IsBinary = true)]
        MMF,

        [CHXMetadata(Value = "image/vnd.fujixerox.edmics-mmr", IsBinary = true)]
        MMR,

        [CHXMetadata(Value = "video/x-mng", IsBinary = true)]
        MNG,

        [CHXMetadata(Value = "application/x-msmoney", IsBinary = true)]
        MNY,

        [CHXMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        MOBI,

        [CHXMetadata(Value = "application/mods+xml", IsText = true)]
        MODS,

        [CHXMetadata(Value = "video/quicktime", IsBinary = true)]
        MOV,

        [CHXMetadata(Value = "video/x-sgi-movie", IsBinary = true)]
        MOVIE,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2,

        [CHXMetadata(Value = "application/mp21", IsBinary = true)]
        MP21,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP2A,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        MP3,

        [CHXMetadata(Value = "video/mp4", IsBinary = true)]
        MP4,

        [CHXMetadata(Value = "audio/mp4", IsBinary = true)]
        MP4A,

        [CHXMetadata(Value = "application/mp4", IsBinary = true)]
        MP4S,

        [CHXMetadata(Value = "video/mp4", IsBinary = true)]
        MP4V,

        [CHXMetadata(Value = "application/vnd.mophun.certificate", IsBinary = true)]
        MPC,

        [CHXMetadata(Value = "video/mpeg", IsBinary = true)]
        MPE,

        [CHXMetadata(Value = "video/mpeg", IsBinary = true)]
        MPEG,

        [CHXMetadata(Value = "video/mpeg", IsBinary = true)]
        MPG,

        [CHXMetadata(Value = "video/mp4", IsBinary = true)]
        MPG4,

        [CHXMetadata(Value = "audio/mpeg", IsBinary = true)]
        MPGA,

        [CHXMetadata(Value = "application/vnd.apple.installer+xml", IsText = true)]
        MPKG,

        [CHXMetadata(Value = "application/vnd.blueice.multipass", IsBinary = true)]
        MPM,

        [CHXMetadata(Value = "application/vnd.mophun.application", IsBinary = true)]
        MPN,

        [CHXMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPP,

        [CHXMetadata(Value = "application/vnd.ms-project", IsBinary = true)]
        MPT,

        [CHXMetadata(Value = "application/vnd.ibm.minipay", IsBinary = true)]
        MPY,

        [CHXMetadata(Value = "application/vnd.mobius.mqy", IsBinary = true)]
        MQY,

        [CHXMetadata(Value = "application/marc", IsBinary = true)]
        MRC,

        [CHXMetadata(Value = "application/marcxml+xml", IsText = true)]
        MRCX,

        [CHXMetadata(Value = "application/x-troff-ms", IsBinary = true)]
        MS,

        [CHXMetadata(Value = "application/mediaservercontrol+xml", IsText = true)]
        MSCML,

        [CHXMetadata(Value = "application/vnd.fdsn.mseed", IsBinary = true)]
        MSEED,

        [CHXMetadata(Value = "application/vnd.mseq", IsBinary = true)]
        MSEQ,

        [CHXMetadata(Value = "application/vnd.epson.msf", IsBinary = true)]
        MSF,

        [CHXMetadata(Value = "model/mesh", IsBinary = true)]
        MSH,

        [CHXMetadata(Value = "application/x-msdownload", IsBinary = true)]
        MSI,

        [CHXMetadata(Value = "application/vnd.mobius.msl", IsBinary = true)]
        MSL,

        [CHXMetadata(Value = "application/vnd.muvee.style", IsBinary = true)]
        MSTY,

        [CHXMetadata(Value = "model/vnd.mts", IsBinary = true)]
        MTS,

        [CHXMetadata(Value = "application/vnd.musician", IsBinary = true)]
        MUS,

        [CHXMetadata(Value = "application/vnd.recordare.musicxml+xml", IsText = true)]
        MUSICXML,

        [CHXMetadata(Value = "application/x-msmediaview", IsBinary = true)]
        MVB,

        [CHXMetadata(Value = "application/vnd.mfer", IsBinary = true)]
        MWF,

        [CHXMetadata(Value = "application/mxf", IsBinary = true)]
        MXF,

        [CHXMetadata(Value = "application/vnd.recordare.musicxml", IsText = true)]
        MXL,

        [CHXMetadata(Value = "application/xv+xml", IsText = true)]
        MXML,

        [CHXMetadata(Value = "application/vnd.triscape.mxs", IsBinary = true)]
        MXS,

        [CHXMetadata(Value = "video/vnd.mpegurl", IsBinary = true)]
        MXU,

        [CHXMetadata(Value = "text/n3", IsText = true)]
        N3,

        [CHXMetadata(Value = "application/mathematica", IsBinary = true)]
        NB,

        [CHXMetadata(Value = "application/vnd.wolfram.player", IsBinary = true)]
        NBP,

        [CHXMetadata(Value = "application/x-netcdf", IsBinary = true)]
        NC,

        [CHXMetadata(Value = "application/x-dtbncx+xml", IsText = true)]
        NCX,

        [CHXMetadata(Value = "text/x-nfo", IsText = true)]
        NFO,

        [CHXMetadata(Value = "application/vnd.nokia.n-gage.data", IsBinary = true)]
        NGDAT,

        [CHXMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NITF,

        [CHXMetadata(Value = "application/vnd.neurolanguage.nlu", IsBinary = true)]
        NLU,

        [CHXMetadata(Value = "application/vnd.enliven", IsBinary = true)]
        NML,

        [CHXMetadata(Value = "application/vnd.noblenet-directory", IsBinary = true)]
        NND,

        [CHXMetadata(Value = "application/vnd.noblenet-sealer", IsBinary = true)]
        NNS,

        [CHXMetadata(Value = "application/vnd.noblenet-web", IsBinary = true)]
        NNW,

        [CHXMetadata(Value = "image/vnd.net-fpx", IsBinary = true)]
        NPX,

        [CHXMetadata(Value = "application/x-conference", IsBinary = true)]
        NSC,

        [CHXMetadata(Value = "application/vnd.lotus-notes", IsBinary = true)]
        NSF,

        [CHXMetadata(Value = "application/vnd.nitf", IsBinary = true)]
        NTF,

        [CHXMetadata(Value = "application/x-nzb", IsBinary = true)]
        NZB,

        [CHXMetadata(Value = "application/vnd.fujitsu.oasys2", IsBinary = true)]
        OA2,

        [CHXMetadata(Value = "application/vnd.fujitsu.oasys3", IsBinary = true)]
        OA3,

        [CHXMetadata(Value = "application/vnd.fujitsu.oasys", IsBinary = true)]
        OAS,

        [CHXMetadata(Value = "application/x-msbinder", IsBinary = true)]
        OBD,

        [CHXMetadata(Value = "application/x-tgif", IsBinary = true)]
        OBJ,

        [CHXMetadata(Value = "application/oda", IsBinary = true)]
        ODA,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.database", IsBinary = true)]
        ODB,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.chart", IsBinary = true)]
        ODC,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.formula", IsBinary = true)]
        ODF,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.formula-template", IsBinary = true)]
        ODFT,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.graphics", IsBinary = true)]
        ODG,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.image", IsBinary = true)]
        ODI,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.text-master", IsBinary = true)]
        ODM,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.presentation", IsBinary = true)]
        ODP,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet", IsBinary = true)]
        ODS,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.text", IsBinary = true)]
        ODT,

        [CHXMetadata(Value = "audio/ogg", IsBinary = true)]
        OGA,

        [CHXMetadata(Value = "video/ogg", IsBinary = true)]
        OGG,

        [CHXMetadata(Value = "video/ogg", IsBinary = true)]
        OGV,

        [CHXMetadata(Value = "application/ogg", IsBinary = true)]
        OGX,

        [CHXMetadata(Value = "application/omdoc+xml", IsText = true)]
        OMDOC,

        [CHXMetadata(Value = "application/onenote", IsBinary = true)]
        ONEPKG,

        [CHXMetadata(Value = "application/onenote", IsBinary = true)]
        ONETMP,

        [CHXMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC,

        [CHXMetadata(Value = "application/onenote", IsBinary = true)]
        ONETOC2,

        [CHXMetadata(Value = "application/oebps-package+xml", IsText = true)]
        OPF,

        [CHXMetadata(Value = "text/x-opml", IsText = true)]
        OPML,

        [CHXMetadata(Value = "application/vnd.palm", IsBinary = true)]
        OPRC,

        [CHXMetadata(Value = "application/vnd.lotus-organizer", IsBinary = true)]
        ORG,

        [CHXMetadata(Value = "application/vnd.yamaha.openscoreformat", IsBinary = true)]
        OSF,

        [CHXMetadata(Value = "application/vnd.yamaha.openscoreformat.osfpvg+xml", IsText = true)]
        OSFPVG,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.chart-template", IsBinary = true)]
        OTC,

        [CHXMetadata(Value = "application/x-font-otf", IsBinary = true)]
        OTF,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.graphics-template", IsBinary = true)]
        OTG,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.text-web", IsBinary = true)]
        OTH,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.image-template", IsBinary = true)]
        OTI,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.presentation-template", IsBinary = true)]
        OTP,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.spreadsheet-template", IsBinary = true)]
        OTS,

        [CHXMetadata(Value = "application/vnd.oasis.opendocument.text-template", IsBinary = true)]
        OTT,

        [CHXMetadata(Value = "application/oxps", IsBinary = true)]
        OXPS,

        [CHXMetadata(Value = "application/vnd.openofficeorg.extension", IsBinary = true)]
        OXT,

        [CHXMetadata(Value = "text/x-pascal", IsText = true)]
        P,

        [CHXMetadata(Value = "application/pkcs10", IsBinary = true)]
        P10,

        [CHXMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        P12,

        [CHXMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        P7B,

        [CHXMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7C,

        [CHXMetadata(Value = "application/pkcs7-mime", IsBinary = true)]
        P7M,

        [CHXMetadata(Value = "application/x-pkcs7-certreqresp", IsBinary = true)]
        P7R,

        [CHXMetadata(Value = "application/pkcs7-signature", IsBinary = true)]
        P7S,

        [CHXMetadata(Value = "application/pkcs8", IsBinary = true)]
        P8,

        [CHXMetadata(Value = "text/x-pascal", IsText = true)]
        PAS,

        [CHXMetadata(Value = "application/vnd.pawaafile", IsBinary = true)]
        PAW,

        [CHXMetadata(Value = "application/vnd.powerbuilder6", IsBinary = true)]
        PBD,

        [CHXMetadata(Value = "image/x-portable-bitmap", IsBinary = true)]
        PBM,

        [CHXMetadata(Value = "application/vnd.tcpdump.pcap", IsBinary = true)]
        PCAP,

        [CHXMetadata(Value = "application/x-font-pcf", IsBinary = true)]
        PCF,

        [CHXMetadata(Value = "application/vnd.hp-pcl", IsBinary = true)]
        PCL,

        [CHXMetadata(Value = "application/vnd.hp-pclxl", IsBinary = true)]
        PCLXL,

        [CHXMetadata(Value = "image/x-pict", IsBinary = true)]
        PCT,

        [CHXMetadata(Value = "application/vnd.curl.pcurl", IsBinary = true)]
        PCURL,

        [CHXMetadata(Value = "image/x-pcx", IsBinary = true)]
        PCX,

        [CHXMetadata(Value = "applicaton/octet-stream", IsBinary = true)]
        PDB,

        [CHXMetadata(Value = "application/pdf", IsBinary = true)]
        PDF,

        [CHXMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFA,

        [CHXMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFB,

        [CHXMetadata(Value = "application/x-font-type1", IsBinary = true)]
        PFM,

        [CHXMetadata(Value = "application/font-tdpfr", IsBinary = true)]
        PFR,

        [CHXMetadata(Value = "application/x-pkcs12", IsBinary = true)]
        PFX,

        [CHXMetadata(Value = "image/x-portable-graymap", IsBinary = true)]
        PGM,

        [CHXMetadata(Value = "application/x-chess-pgn", IsBinary = true)]
        PGN,

        [CHXMetadata(Value = "application/pgp-encrypted", IsBinary = true)]
        PGP,

        [CHXMetadata(Value = "image/x-pict", IsBinary = true)]
        PIC,

        [CHXMetadata(Value = "image/pict", IsBinary = true)]
        PICT,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        PKG,

        [CHXMetadata(Value = "application/pkixcmp", IsBinary = true)]
        PKI,

        [CHXMetadata(Value = "application/pkix-pkipath", IsBinary = true)]
        PKIPATH,

        [CHXMetadata(Value = "application/vnd.3gpp.pic-bw-large", IsBinary = true)]
        PLB,

        [CHXMetadata(Value = "application/vnd.mobius.plc", IsBinary = true)]
        PLC,

        [CHXMetadata(Value = "application/vnd.pocketlearn", IsBinary = true)]
        PLF,

        [CHXMetadata(Value = "application/pls+xml", IsText = true)]
        PLS,

        [CHXMetadata(Value = "application/vnd.ctc-posml", IsBinary = true)]
        PML,

        [CHXMetadata(Value = "image/png", IsBinary = true)]
        PNG,

        [CHXMetadata(Value = "image/x-portable-anymap", IsBinary = true)]
        PNM,

        [CHXMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNT,

        [CHXMetadata(Value = "image/x-macpaint", IsBinary = true)]
        PNTG,

        [CHXMetadata(Value = "application/vnd.macports.portpkg", IsBinary = true)]
        PORTPKG,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        POT,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint.template.macroenabled.12", IsBinary = true)]
        POTM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.template", IsBinary = true)]
        POTX,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint.addin.macroenabled.12", IsBinary = true)]
        PPAM,

        [CHXMetadata(Value = "application/vnd.cups-ppd", IsBinary = true)]
        PPD,

        [CHXMetadata(Value = "image/x-portable-pixmap", IsBinary = true)]
        PPM,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPS,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint.slideshow.macroenabled.12", IsBinary = true)]
        PPSM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slideshow", IsBinary = true)]
        PPSX,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint", IsBinary = true)]
        PPT,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint.presentation.macroenabled.12", IsBinary = true)]
        PPTM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.presentation", IsBinary = true)]
        PPTX,

        [CHXMetadata(Value = "application/vnd.palm", IsBinary = true)]
        PQA,

        [CHXMetadata(Value = "application/x-mobipocket-ebook", IsBinary = true)]
        PRC,

        [CHXMetadata(Value = "application/vnd.lotus-freelance", IsBinary = true)]
        PRE,

        [CHXMetadata(Value = "application/pics-rules", IsBinary = true)]
        PRF,

        [CHXMetadata(Value = "application/postscript", IsBinary = true)]
        PS,

        [CHXMetadata(Value = "application/vnd.3gpp.pic-bw-small", IsBinary = true)]
        PSB,

        [CHXMetadata(Value = "image/vnd.adobe.photoshop", IsBinary = true)]
        PSD,

        [CHXMetadata(Value = "application/x-font-linux-psf", IsBinary = true)]
        PSF,

        [CHXMetadata(Value = "application/pskc+xml", IsText = true)]
        PSKCXML,

        [CHXMetadata(Value = "application/vnd.pvi.ptid1", IsBinary = true)]
        PTID,

        [CHXMetadata(Value = "application/x-mspublisher", IsBinary = true)]
        PUB,

        [CHXMetadata(Value = "application/vnd.3gpp.pic-bw-var", IsBinary = true)]
        PVB,

        [CHXMetadata(Value = "application/vnd.3m.post-it-notes", IsBinary = true)]
        PWN,

        [CHXMetadata(Value = "audio/vnd.ms-playready.media.pya", IsBinary = true)]
        PYA,

        [CHXMetadata(Value = "video/vnd.ms-playready.media.pyv", IsBinary = true)]
        PYV,

        [CHXMetadata(Value = "application/vnd.epson.quickanime", IsBinary = true)]
        QAM,

        [CHXMetadata(Value = "application/vnd.intu.qbo", IsBinary = true)]
        QBO,

        [CHXMetadata(Value = "application/vnd.intu.qfx", IsBinary = true)]
        QFX,

        [CHXMetadata(Value = "application/vnd.publishare-delta-tree", IsBinary = true)]
        QPS,

        [CHXMetadata(Value = "video/quicktime", IsBinary = true)]
        QT,

        [CHXMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTI,

        [CHXMetadata(Value = "image/x-quicktime", IsBinary = true)]
        QTIF,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWD,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QWT,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXB,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXD,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXL,

        [CHXMetadata(Value = "application/vnd.quark.quarkxpress", IsBinary = true)]
        QXT,

        [CHXMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RA,

        [CHXMetadata(Value = "audio/x-pn-realaudio", IsBinary = true)]
        RAM,

        [CHXMetadata(Value = "application/x-rar-compressed", IsBinary = true)]
        RAR,

        [CHXMetadata(Value = "image/x-cmu-raster", IsBinary = true)]
        RAS,

        [CHXMetadata(Value = "application/vnd.ipunplugged.rcprofile", IsBinary = true)]
        RCPROFILE,

        [CHXMetadata(Value = "application/rdf+xml", IsText = true)]
        RDF,

        [CHXMetadata(Value = "application/vnd.data-vision.rdz", IsBinary = true)]
        RDZ,

        [CHXMetadata(Value = "application/vnd.businessobjects", IsBinary = true)]
        REP,

        [CHXMetadata(Value = "application/x-dtbresource+xml", IsText = true)]
        RES,

        [CHXMetadata(Value = "image/x-rgb", IsBinary = true)]
        RGB,

        [CHXMetadata(Value = "application/reginfo+xml", IsText = true)]
        RIF,

        [CHXMetadata(Value = "audio/vnd.rip", IsBinary = true)]
        RIP,

        [CHXMetadata(Value = "application/x-research-info-systems", IsBinary = true)]
        RIS,

        [CHXMetadata(Value = "application/resource-lists+xml", IsText = true)]
        RL,

        [CHXMetadata(Value = "image/vnd.fujixerox.edmics-rlc", IsBinary = true)]
        RLC,

        [CHXMetadata(Value = "application/resource-lists-diff+xml", IsText = true)]
        RLD,

        [CHXMetadata(Value = "application/vnd.rn-realmedia", IsBinary = true)]
        RM,

        [CHXMetadata(Value = "audio/midi", IsBinary = true)]
        RMI,

        [CHXMetadata(Value = "audio/x-pn-realaudio-plugin", IsBinary = true)]
        RMP,

        [CHXMetadata(Value = "application/vnd.jcp.javame.midlet-rms", IsBinary = true)]
        RMS,

        [CHXMetadata(Value = "application/vnd.rn-realmedia-vbr", IsBinary = true)]
        RMVB,

        [CHXMetadata(Value = "application/relax-ng-compact-syntax", IsBinary = true)]
        RNC,

        [CHXMetadata(Value = "application/rpki-roa", IsBinary = true)]
        ROA,

        [CHXMetadata(Value = "application/x-troff", IsBinary = true)]
        ROFF,

        [CHXMetadata(Value = "application/vnd.cloanto.rp9", IsBinary = true)]
        RP9,

        [CHXMetadata(Value = "application/vnd.nokia.radio-presets", IsBinary = true)]
        RPSS,

        [CHXMetadata(Value = "application/vnd.nokia.radio-preset", IsBinary = true)]
        RPST,

        [CHXMetadata(Value = "application/sparql-query", IsBinary = true)]
        RQ,

        [CHXMetadata(Value = "application/rls-services+xml", IsText = true)]
        RS,

        [CHXMetadata(Value = "application/rsd+xml", IsText = true)]
        RSD,

        [CHXMetadata(Value = "application/rss+xml", IsText = true)]
        RSS,

        [CHXMetadata(Value = "application/rtf", IsBinary = true)]
        RTF,

        [CHXMetadata(Value = "text/richtext", IsText = true)]
        RTX,

        [CHXMetadata(Value = "text/x-asm", IsText = true)]
        S,

        [CHXMetadata(Value = "audio/s3m", IsBinary = true)]
        S3M,

        [CHXMetadata(Value = "application/vnd.yamaha.smaf-audio", IsBinary = true)]
        SAF,

        [CHXMetadata(Value = "application/sbml+xml", IsText = true)]
        SBML,

        [CHXMetadata(Value = "application/vnd.ibm.secure-container", IsBinary = true)]
        SC,

        [CHXMetadata(Value = "application/x-msschedule", IsBinary = true)]
        SCD,

        [CHXMetadata(Value = "application/vnd.lotus-screencam", IsBinary = true)]
        SCM,

        [CHXMetadata(Value = "application/scvp-cv-request", IsBinary = true)]
        SCQ,

        [CHXMetadata(Value = "application/scvp-cv-response", IsBinary = true)]
        SCS,

        [CHXMetadata(Value = "text/vnd.curl.scurl", IsText = true)]
        SCURL,

        [CHXMetadata(Value = "application/vnd.stardivision.draw", IsBinary = true)]
        SDA,

        [CHXMetadata(Value = "application/vnd.stardivision.calc", IsBinary = true)]
        SDC,

        [CHXMetadata(Value = "application/vnd.stardivision.impress", IsBinary = true)]
        SDD,

        [CHXMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKD,

        [CHXMetadata(Value = "application/vnd.solent.sdkm+xml", IsText = true)]
        SDKM,

        [CHXMetadata(Value = "application/sdp", IsBinary = true)]
        SDP,

        [CHXMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        SDW,

        [CHXMetadata(Value = "application/vnd.seemail", IsBinary = true)]
        SEE,

        [CHXMetadata(Value = "application/vnd.fdsn.seed", IsBinary = true)]
        SEED,

        [CHXMetadata(Value = "application/vnd.sema", IsBinary = true)]
        SEMA,

        [CHXMetadata(Value = "application/vnd.semd", IsBinary = true)]
        SEMD,

        [CHXMetadata(Value = "application/vnd.semf", IsBinary = true)]
        SEMF,

        [CHXMetadata(Value = "application/java-serialized-object", IsBinary = true)]
        SER,

        [CHXMetadata(Value = "application/set-payment-initiation", IsBinary = true)]
        SETPAY,

        [CHXMetadata(Value = "application/set-registration-initiation", IsBinary = true)]
        SETREG,

        [CHXMetadata(Value = "application/vnd.spotfire.sfs", IsBinary = true)]
        SFS,

        [CHXMetadata(Value = "text/x-sfv", IsText = true)]
        SFV,

        [CHXMetadata(Value = "image/sgi", IsBinary = true)]
        SGI,

        [CHXMetadata(Value = "application/vnd.stardivision.writer-global", IsBinary = true)]
        SGL,

        [CHXMetadata(Value = "text/sgml", IsText = true)]
        SGM,

        [CHXMetadata(Value = "text/sgml", IsText = true)]
        SGML,

        [CHXMetadata(Value = "application/x-sh", IsBinary = true)]
        SH,

        [CHXMetadata(Value = "application/x-shar", IsBinary = true)]
        SHAR,

        [CHXMetadata(Value = "application/shf+xml", IsText = true)]
        SHF,

        [CHXMetadata(Value = "image/x-mrsid-image", IsBinary = true)]
        SID,

        [CHXMetadata(Value = "application/pgp-signature", IsBinary = true)]
        SIG,

        [CHXMetadata(Value = "audio/silk", IsBinary = true)]
        SIL,

        [CHXMetadata(Value = "model/mesh", IsBinary = true)]
        SILO,

        [CHXMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SIS,

        [CHXMetadata(Value = "application/vnd.symbian.install", IsBinary = true)]
        SISX,

        [CHXMetadata(Value = "application/x-stuffit", IsBinary = true)]
        SIT,

        [CHXMetadata(Value = "application/x-stuffitx", IsBinary = true)]
        SITX,

        [CHXMetadata(Value = "application/x-koan", IsBinary = true)]
        SKD,

        [CHXMetadata(Value = "application/x-koan", IsBinary = true)]
        SKM,

        [CHXMetadata(Value = "application/x-koan", IsBinary = true)]
        SKP,

        [CHXMetadata(Value = "application/x-koan", IsBinary = true)]
        SKT,

        [CHXMetadata(Value = "application/vnd.ms-powerpoint.slide.macroenabled.12", IsBinary = true)]
        SLDM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.presentationml.slide", IsBinary = true)]
        SLDX,

        [CHXMetadata(Value = "application/vnd.epson.salt", IsBinary = true)]
        SLT,

        [CHXMetadata(Value = "application/vnd.stepmania.stepchart", IsBinary = true)]
        SM,

        [CHXMetadata(Value = "application/vnd.stardivision.math", IsBinary = true)]
        SMF,

        [CHXMetadata(Value = "application/smil+xml", IsText = true)]
        SMI,

        [CHXMetadata(Value = "application/smil+xml", IsText = true)]
        SMIL,

        [CHXMetadata(Value = "video/x-smv", IsBinary = true)]
        SMV,

        [CHXMetadata(Value = "application/vnd.stepmania.package", IsBinary = true)]
        SMZIP,

        [CHXMetadata(Value = "audio/basic", IsBinary = true)]
        SND,

        [CHXMetadata(Value = "application/x-font-snf", IsBinary = true)]
        SNF,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        SO,

        [CHXMetadata(Value = "application/x-pkcs7-certificates", IsBinary = true)]
        SPC,

        [CHXMetadata(Value = "application/vnd.yamaha.smaf-phrase", IsBinary = true)]
        SPF,

        [CHXMetadata(Value = "application/x-futuresplash", IsBinary = true)]
        SPL,

        [CHXMetadata(Value = "text/vnd.in3d.spot", IsText = true)]
        SPOT,

        [CHXMetadata(Value = "application/scvp-vp-response", IsBinary = true)]
        SPP,

        [CHXMetadata(Value = "application/scvp-vp-request", IsBinary = true)]
        SPQ,

        [CHXMetadata(Value = "audio/ogg", IsBinary = true)]
        SPX,

        [CHXMetadata(Value = "application/x-sql", IsBinary = true)]
        SQL,

        [CHXMetadata(Value = "application/x-wais-source", IsBinary = true)]
        SRC,

        [CHXMetadata(Value = "application/x-subrip", IsBinary = true)]
        SRT,

        [CHXMetadata(Value = "application/sru+xml", IsText = true)]
        SRU,

        [CHXMetadata(Value = "application/sparql-results+xml", IsText = true)]
        SRX,

        [CHXMetadata(Value = "application/ssdl+xml", IsText = true)]
        SSDL,

        [CHXMetadata(Value = "application/vnd.kodak-descriptor", IsBinary = true)]
        SSE,

        [CHXMetadata(Value = "application/vnd.epson.ssf", IsBinary = true)]
        SSF,

        [CHXMetadata(Value = "application/ssml+xml", IsText = true)]
        SSML,

        [CHXMetadata(Value = "application/vnd.sailingtracker.track", IsBinary = true)]
        ST,

        [CHXMetadata(Value = "application/vnd.sun.xml.calc.template", IsBinary = true)]
        STC,

        [CHXMetadata(Value = "application/vnd.sun.xml.draw.template", IsBinary = true)]
        STD,

        [CHXMetadata(Value = "application/vnd.wt.stf", IsBinary = true)]
        STF,

        [CHXMetadata(Value = "application/vnd.sun.xml.impress.template", IsBinary = true)]
        STI,

        [CHXMetadata(Value = "application/hyperstudio", IsBinary = true)]
        STK,

        [CHXMetadata(Value = "application/vnd.ms-pki.stl", IsBinary = true)]
        STL,

        [CHXMetadata(Value = "application/vnd.pg.format", IsBinary = true)]
        STR,

        [CHXMetadata(Value = "application/vnd.sun.xml.writer.template", IsBinary = true)]
        STW,

        [CHXMetadata(Value = "text/vnd.dvb.subtitle", IsText = true)]
        SUB,

        [CHXMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUS,

        [CHXMetadata(Value = "application/vnd.sus-calendar", IsBinary = true)]
        SUSP,

        [CHXMetadata(Value = "application/x-sv4cpio", IsBinary = true)]
        SV4CPIO,

        [CHXMetadata(Value = "application/x-sv4crc", IsBinary = true)]
        SV4CRC,

        [CHXMetadata(Value = "application/vnd.dvb.service", IsBinary = true)]
        SVC,

        [CHXMetadata(Value = "application/vnd.svd", IsBinary = true)]
        SVD,

        [CHXMetadata(Value = "image/svg+xml", IsText = true)]
        SVG,

        [CHXMetadata(Value = "image/svg+xml", IsText = true)]
        SVGZ,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        SWA,

        [CHXMetadata(Value = "application/x-shockwave-flash", IsBinary = true)]
        SWF,

        [CHXMetadata(Value = "application/vnd.aristanetworks.swi", IsBinary = true)]
        SWI,

        [CHXMetadata(Value = "application/vnd.sun.xml.calc", IsBinary = true)]
        SXC,

        [CHXMetadata(Value = "application/vnd.sun.xml.draw", IsBinary = true)]
        SXD,

        [CHXMetadata(Value = "application/vnd.sun.xml.writer.global", IsBinary = true)]
        SXG,

        [CHXMetadata(Value = "application/vnd.sun.xml.impress", IsBinary = true)]
        SXI,

        [CHXMetadata(Value = "application/vnd.sun.xml.math", IsBinary = true)]
        SXM,

        [CHXMetadata(Value = "application/vnd.sun.xml.writer", IsBinary = true)]
        SXW,

        [CHXMetadata(Value = "application/x-troff", IsBinary = true)]
        T,

        [CHXMetadata(Value = "application/x-t3vm-image", IsBinary = true)]
        T3,

        [CHXMetadata(Value = "application/vnd.mynfc", IsBinary = true)]
        TAGLET,

        [CHXMetadata(Value = "application/vnd.tao.intent-module-archive", IsBinary = true)]
        TAO,

        [CHXMetadata(Value = "application/x-tar", IsBinary = true)]
        TAR,

        [CHXMetadata(Value = "application/vnd.3gpp2.tcap", IsBinary = true)]
        TCAP,

        [CHXMetadata(Value = "application/x-tcl", IsBinary = true)]
        TCL,

        [CHXMetadata(Value = "application/vnd.smart.teacher", IsBinary = true)]
        TEACHER,

        [CHXMetadata(Value = "application/tei+xml", IsText = true)]
        TEI,

        [CHXMetadata(Value = "application/tei+xml", IsText = true)]
        TEICORPUS,

        [CHXMetadata(Value = "application/x-tex", IsBinary = true)]
        TEX,

        [CHXMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXI,

        [CHXMetadata(Value = "application/x-texinfo", IsBinary = true)]
        TEXINFO,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        TEXT,

        [CHXMetadata(Value = "application/thraud+xml", IsText = true)]
        TFI,

        [CHXMetadata(Value = "application/x-tex-tfm", IsBinary = true)]
        TFM,

        [CHXMetadata(Value = "image/x-tga", IsBinary = true)]
        TGA,

        [CHXMetadata(Value = "application/vnd.ms-officetheme", IsBinary = true)]
        THMX,

        [CHXMetadata(Value = "image/tiff", IsBinary = true)]
        TIF,

        [CHXMetadata(Value = "image/tiff", IsBinary = true)]
        TIFF,

        [CHXMetadata(Value = "application/vnd.tmobile-livetv", IsBinary = true)]
        TMO,

        [CHXMetadata(Value = "application/x-bittorrent", IsBinary = true)]
        TORRENT,

        [CHXMetadata(Value = "application/vnd.groove-tool-template", IsBinary = true)]
        TPL,

        [CHXMetadata(Value = "application/vnd.trid.tpt", IsBinary = true)]
        TPT,

        [CHXMetadata(Value = "application/x-troff", IsBinary = true)]
        TR,

        [CHXMetadata(Value = "application/vnd.trueapp", IsBinary = true)]
        TRA,

        [CHXMetadata(Value = "application/x-msterminal", IsBinary = true)]
        TRM,

        [CHXMetadata(Value = "application/timestamped-data", IsBinary = true)]
        TSD,

        [CHXMetadata(Value = "text/tab-separated-values", IsText = true)]
        TSV,

        [CHXMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTC,

        [CHXMetadata(Value = "application/x-font-ttf", IsBinary = true)]
        TTF,

        [CHXMetadata(Value = "text/turtle", IsText = true)]
        TTL,

        [CHXMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWD,

        [CHXMetadata(Value = "application/vnd.simtech-mindmapper", IsBinary = true)]
        TWDS,

        [CHXMetadata(Value = "application/vnd.genomatix.tuxedo", IsBinary = true)]
        TXD,

        [CHXMetadata(Value = "application/vnd.mobius.txf", IsBinary = true)]
        TXF,

        [CHXMetadata(Value = "text/plain", IsText = true)]
        TXT,

        [CHXMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        U32,

        [CHXMetadata(Value = "application/x-debian-package", IsBinary = true)]
        UDEB,

        [CHXMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFD,

        [CHXMetadata(Value = "application/vnd.ufdl", IsBinary = true)]
        UFDL,

        [CHXMetadata(Value = "application/x-glulx", IsBinary = true)]
        ULX,

        [CHXMetadata(Value = "application/vnd.umajin", IsBinary = true)]
        UMJ,

        [CHXMetadata(Value = "application/vnd.unity", IsBinary = true)]
        UNITYWEB,

        [CHXMetadata(Value = "application/vnd.uoml+xml", IsText = true)]
        UOML,

        [CHXMetadata(Value = "text/uri-list", IsText = true)]
        URI,

        [CHXMetadata(Value = "text/uri-list", IsText = true)]
        URIS,

        [CHXMetadata(Value = "text/uri-list", IsText = true)]
        URLS,

        [CHXMetadata(Value = "application/x-ustar", IsBinary = true)]
        USTAR,

        [CHXMetadata(Value = "application/vnd.uiq.theme", IsBinary = true)]
        UTZ,

        [CHXMetadata(Value = "text/x-uuencode", IsText = true)]
        UU,

        [CHXMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVA,

        [CHXMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVD,

        [CHXMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVF,

        [CHXMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVG,

        [CHXMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVH,

        [CHXMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVI,

        [CHXMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVM,

        [CHXMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVP,

        [CHXMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVS,

        [CHXMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVT,

        [CHXMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVU,

        [CHXMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVV,

        [CHXMetadata(Value = "audio/vnd.dece.audio", IsBinary = true)]
        UVVA,

        [CHXMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVD,

        [CHXMetadata(Value = "application/vnd.dece.data", IsBinary = true)]
        UVVF,

        [CHXMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVG,

        [CHXMetadata(Value = "video/vnd.dece.hd", IsBinary = true)]
        UVVH,

        [CHXMetadata(Value = "image/vnd.dece.graphic", IsBinary = true)]
        UVVI,

        [CHXMetadata(Value = "video/vnd.dece.mobile", IsBinary = true)]
        UVVM,

        [CHXMetadata(Value = "video/vnd.dece.pd", IsBinary = true)]
        UVVP,

        [CHXMetadata(Value = "video/vnd.dece.sd", IsBinary = true)]
        UVVS,

        [CHXMetadata(Value = "application/vnd.dece.ttml+xml", IsText = true)]
        UVVT,

        [CHXMetadata(Value = "video/vnd.uvvu.mp4", IsBinary = true)]
        UVVU,

        [CHXMetadata(Value = "video/vnd.dece.video", IsBinary = true)]
        UVVV,

        [CHXMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVVX,

        [CHXMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVVZ,

        [CHXMetadata(Value = "application/vnd.dece.unspecified", IsBinary = true)]
        UVX,

        [CHXMetadata(Value = "application/vnd.dece.zip", IsBinary = true)]
        UVZ,

        [CHXMetadata(Value = "text/vcard", IsText = true)]
        VCARD,

        [CHXMetadata(Value = "application/x-cdlink", IsBinary = true)]
        VCD,

        [CHXMetadata(Value = "text/x-vcard", IsText = true)]
        VCF,

        [CHXMetadata(Value = "application/vnd.groove-vcard", IsBinary = true)]
        VCG,

        [CHXMetadata(Value = "text/x-vcalendar", IsText = true)]
        VCS,

        [CHXMetadata(Value = "application/vnd.vcx", IsBinary = true)]
        VCX,

        [CHXMetadata(Value = "application/vnd.visionary", IsBinary = true)]
        VIS,

        [CHXMetadata(Value = "video/vnd.vivo", IsBinary = true)]
        VIV,

        [CHXMetadata(Value = "video/x-ms-vob", IsBinary = true)]
        VOB,

        [CHXMetadata(Value = "application/vnd.stardivision.writer", IsBinary = true)]
        VOR,

        [CHXMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        VOX,

        [CHXMetadata(Value = "model/vrml", IsBinary = true)]
        VRML,

        [CHXMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSD,

        [CHXMetadata(Value = "application/vnd.vsf", IsBinary = true)]
        VSF,

        [CHXMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSS,

        [CHXMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VST,

        [CHXMetadata(Value = "application/vnd.visio", IsBinary = true)]
        VSW,

        [CHXMetadata(Value = "model/vnd.vtu", IsBinary = true)]
        VTU,

        [CHXMetadata(Value = "application/voicexml+xml", IsText = true)]
        VXML,

        [CHXMetadata(Value = "application/x-director", IsBinary = true)]
        W3D,

        [CHXMetadata(Value = "application/x-doom", IsBinary = true)]
        WAD,

        [CHXMetadata(Value = "audio/x-wav", IsBinary = true)]
        WAV,

        [CHXMetadata(Value = "audio/x-ms-wax", IsBinary = true)]
        WAX,

        [CHXMetadata(Value = "image/vnd.wap.wbmp", IsBinary = true)]
        WBMP,

        [CHXMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBMXL,

        [CHXMetadata(Value = "application/vnd.criticaltools.wbs+xml", IsText = true)]
        WBS,

        [CHXMetadata(Value = "application/vnd.wap.wbxml", IsText = true)]
        WBXML,

        [CHXMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WCM,

        [CHXMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WDB,

        [CHXMetadata(Value = "image/vnd.ms-photo", IsBinary = true)]
        WDP,

        [CHXMetadata(Value = "audio/webm", IsBinary = true)]
        WEBA,

        [CHXMetadata(Value = "video/webm", IsBinary = true)]
        WEBM,

        [CHXMetadata(Value = "image/webp", IsBinary = true)]
        WEBP,

        [CHXMetadata(Value = "application/vnd.pmi.widget", IsBinary = true)]
        WG,

        [CHXMetadata(Value = "application/widget", IsBinary = true)]
        WGT,

        [CHXMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WKS,

        [CHXMetadata(Value = "video/x-ms-wm", IsBinary = true)]
        WM,

        [CHXMetadata(Value = "audio/x-ms-wma", IsBinary = true)]
        WMA,

        [CHXMetadata(Value = "application/x-ms-wmd", IsBinary = true)]
        WMD,

        [CHXMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMF,

        [CHXMetadata(Value = "text/vnd.wap.wml", IsText = true)]
        WML,

        [CHXMetadata(Value = "application/vnd.wap.wmlc", IsBinary = true)]
        WMLC,

        [CHXMetadata(Value = "text/vnd.wap.wmlscript", IsText = true)]
        WMLS,

        [CHXMetadata(Value = "application/vnd.wap.wmlscriptc", IsBinary = true)]
        WMLSC,

        [CHXMetadata(Value = "video/x-ms-wmv", IsBinary = true)]
        WMV,

        [CHXMetadata(Value = "video/x-ms-wmx", IsBinary = true)]
        WMX,

        [CHXMetadata(Value = "application/x-msmetafile", IsBinary = true)]
        WMZ,

        [CHXMetadata(Value = "application/font-woff", IsBinary = true)]
        WOFF,

        [CHXMetadata(Value = "application/vnd.wordperfect", IsBinary = true)]
        WPD,

        [CHXMetadata(Value = "application/vnd.ms-wpl", IsBinary = true)]
        WPL,

        [CHXMetadata(Value = "application/vnd.ms-works", IsBinary = true)]
        WPS,

        [CHXMetadata(Value = "application/vnd.wqd", IsBinary = true)]
        WQD,

        [CHXMetadata(Value = "application/x-mswrite", IsBinary = true)]
        WRI,

        [CHXMetadata(Value = "model/vrml", IsBinary = true)]
        WRL,

        [CHXMetadata(Value = "application/wsdl+xml", IsText = true)]
        WSDL,

        [CHXMetadata(Value = "application/wspolicy+xml", IsText = true)]
        WSPOLICY,

        [CHXMetadata(Value = "application/vnd.webturbo", IsBinary = true)]
        WTB,

        [CHXMetadata(Value = "video/x-ms-wvx", IsBinary = true)]
        WVX,

        [CHXMetadata(Value = "application/x-authorware-bin", IsBinary = true)]
        X32,

        [CHXMetadata(Value = "model/x3d+xml", IsText = true)]
        X3D,

        [CHXMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DB,

        [CHXMetadata(Value = "model/x3d+binary", IsBinary = true)]
        X3DBZ,

        [CHXMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DV,

        [CHXMetadata(Value = "model/x3d+vrml", IsBinary = true)]
        X3DVZ,

        [CHXMetadata(Value = "model/x3d+xml", IsText = true)]
        X3DZ,

        [CHXMetadata(Value = "application/xaml+xml", IsText = true)]
        XAML,

        [CHXMetadata(Value = "application/x-silverlight-app", IsBinary = true)]
        XAP,

        [CHXMetadata(Value = "application/vnd.xara", IsBinary = true)]
        XAR,

        [CHXMetadata(Value = "application/x-ms-xbap", IsBinary = true)]
        XBAP,

        [CHXMetadata(Value = "application/vnd.fujixerox.docuworks.binder", IsBinary = true)]
        XBD,

        [CHXMetadata(Value = "image/x-xbitmap", IsBinary = true)]
        XBM,

        [CHXMetadata(Value = "application/xcap-diff+xml", IsText = true)]
        XDF,

        [CHXMetadata(Value = "application/vnd.syncml.dm+xml", IsText = true)]
        XDM,

        [CHXMetadata(Value = "application/vnd.adobe.xdp+xml", IsText = true)]
        XDP,

        [CHXMetadata(Value = "application/dssc+xml", IsText = true)]
        XDSSC,

        [CHXMetadata(Value = "application/vnd.fujixerox.docuworks", IsBinary = true)]
        XDW,

        [CHXMetadata(Value = "application/xenc+xml", IsText = true)]
        XENC,

        [CHXMetadata(Value = "application/patch-ops-error+xml", IsText = true)]
        XER,

        [CHXMetadata(Value = "application/vnd.adobe.xfdf", IsBinary = true)]
        XFDF,

        [CHXMetadata(Value = "application/vnd.xfdl", IsBinary = true)]
        XFDL,

        [CHXMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHT,

        [CHXMetadata(Value = "application/xhtml+xml", IsText = true)]
        XHTML,

        [CHXMetadata(Value = "application/xv+xml", IsText = true)]
        XHVML,

        [CHXMetadata(Value = "image/vnd.xiff", IsBinary = true)]
        XIF,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLA,

        [CHXMetadata(Value = "application/vnd.ms-excel.addin.macroenabled.12", IsBinary = true)]
        XLAM,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLC,

        [CHXMetadata(Value = "application/x-xliff+xml", IsText = true)]
        XLF,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLM,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLS,

        [CHXMetadata(Value = "application/vnd.ms-excel.sheet.binary.macroenabled.12", IsBinary = true)]
        XLSB,

        [CHXMetadata(Value = "application/vnd.ms-excel.sheet.macroenabled.12", IsBinary = true)]
        XLSM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", IsBinary = true)]
        XLSX,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLT,

        [CHXMetadata(Value = "application/vnd.ms-excel.template.macroenabled.12", IsBinary = true)]
        XLTM,

        [CHXMetadata(Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.template", IsBinary = true)]
        XLTX,

        [CHXMetadata(Value = "application/vnd.ms-excel", IsBinary = true)]
        XLW,

        [CHXMetadata(Value = "audio/xm", IsBinary = true)]
        XM,

        [CHXMetadata(Value = "application/xml", IsText = true)]
        XML,

        [CHXMetadata(Value = "application/vnd.olpc-sugar", IsBinary = true)]
        XO,

        [CHXMetadata(Value = "application/xop+xml", IsText = true)]
        XOP,

        [CHXMetadata(Value = "application/x-xpinstall", IsBinary = true)]
        XPI,

        [CHXMetadata(Value = "application/xproc+xml", IsText = true)]
        XPL,

        [CHXMetadata(Value = "image/x-xpixmap", IsBinary = true)]
        XPM,

        [CHXMetadata(Value = "application/vnd.is-xpr", IsBinary = true)]
        XPR,

        [CHXMetadata(Value = "application/vnd.ms-xpsdocument", IsBinary = true)]
        XPS,

        [CHXMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPW,

        [CHXMetadata(Value = "application/vnd.intercon.formnet", IsBinary = true)]
        XPX,

        [CHXMetadata(Value = "application/xml", IsText = true)]
        XSL,

        [CHXMetadata(Value = "application/xslt+xml", IsText = true)]
        XSLT,

        [CHXMetadata(Value = "application/vnd.syncml+xml", IsText = true)]
        XSM,

        [CHXMetadata(Value = "application/xspf+xml", IsText = true)]
        XSPF,

        [CHXMetadata(Value = "application/vnd.mozilla.xul+xml", IsText = true)]
        XUL,

        [CHXMetadata(Value = "application/xv+xml", IsText = true)]
        XVM,

        [CHXMetadata(Value = "application/xv+xml", IsText = true)]
        XVML,

        [CHXMetadata(Value = "image/x-xwindowdump", IsBinary = true)]
        XWD,

        [CHXMetadata(Value = "chemical/x-xyz", IsBinary = true)]
        XYZ,

        [CHXMetadata(Value = "application/x-xz", IsBinary = true)]
        XZ,

        [CHXMetadata(Value = "application/yang", IsBinary = true)]
        YANG,

        [CHXMetadata(Value = "application/yin+xml", IsText = true)]
        YIN,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z1,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z2,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z3,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z4,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z5,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z6,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z7,

        [CHXMetadata(Value = "application/x-zmachine", IsBinary = true)]
        Z8,

        [CHXMetadata(Value = "application/vnd.zzazz.deck+xml", IsText = true)]
        ZAZ,

        [CHXMetadata(Value = "application/zip", IsBinary = true)]
        ZIP,

        [CHXMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIR,

        [CHXMetadata(Value = "application/vnd.zul", IsBinary = true)]
        ZIRZ,

        [CHXMetadata(Value = "application/vnd.handheld-entertainment+xml", IsText = true)]
        ZMM,

        [CHXMetadata(Value = "application/octet-stream", IsBinary = true)]
        DEFAULT
    }
}
