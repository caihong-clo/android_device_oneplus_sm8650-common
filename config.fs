# AIDs and the common QTI paths come from device/qcom/common/config.fs.
# Only the entries it lacks are kept here.

[vendor/bin/hw/android.hardware.security.keymint3-service.strongbox.nxp]
mode: 0755
user: AID_VENDOR_NXP_STRONGBOX
group: AID_SYSTEM
caps: SYS_ADMIN SYS_NICE WAKE_ALARM

[soccp_firmware/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0

[dcp_firmware/]
mode: 0771
user: AID_ROOT
group: AID_SYSTEM
caps: 0
