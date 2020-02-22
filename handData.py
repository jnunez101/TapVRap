from tapsdk import TapSDK
tap_device = TapSDK()

tap_device.set_input_mode(TapInputMode('raw', sensitivity=[2,1,4]))

