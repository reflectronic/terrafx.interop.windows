// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/EvColl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("EC_HANDLE")]
        public static extern IntPtr EcOpenSubscriptionEnum([NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcEnumNextSubscription([NativeTypeName("EC_HANDLE")] IntPtr SubscriptionEnum, [NativeTypeName("DWORD")] uint SubscriptionNameBufferSize, [NativeTypeName("LPWSTR")] ushort* SubscriptionNameBuffer, [NativeTypeName("PDWORD")] uint* SubscriptionNameBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("EC_HANDLE")]
        public static extern IntPtr EcOpenSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint AccessMask, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcSetSubscriptionProperty([NativeTypeName("EC_HANDLE")] IntPtr Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcGetSubscriptionProperty([NativeTypeName("EC_HANDLE")] IntPtr Subscription, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcSaveSubscription([NativeTypeName("EC_HANDLE")] IntPtr Subscription, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcDeleteSubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcGetObjectArraySize([NativeTypeName("EC_OBJECT_ARRAY_PROPERTY_HANDLE")] IntPtr ObjectArray, [NativeTypeName("PDWORD")] uint* ObjectArraySize);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcSetObjectArrayProperty([NativeTypeName("EC_OBJECT_ARRAY_PROPERTY_HANDLE")] IntPtr ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValue);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcGetObjectArrayProperty([NativeTypeName("EC_OBJECT_ARRAY_PROPERTY_HANDLE")] IntPtr ObjectArray, EC_SUBSCRIPTION_PROPERTY_ID PropertyId, [NativeTypeName("DWORD")] uint ArrayIndex, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint PropertyValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* PropertyValueBuffer, [NativeTypeName("PDWORD")] uint* PropertyValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcInsertObjectArrayElement([NativeTypeName("EC_OBJECT_ARRAY_PROPERTY_HANDLE")] IntPtr ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcRemoveObjectArrayElement([NativeTypeName("EC_OBJECT_ARRAY_PROPERTY_HANDLE")] IntPtr ObjectArray, [NativeTypeName("DWORD")] uint ArrayIndex);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcGetSubscriptionRunTimeStatus([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, EC_SUBSCRIPTION_RUNTIME_STATUS_INFO_ID StatusInfoId, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags, [NativeTypeName("DWORD")] uint StatusValueBufferSize, [NativeTypeName("PEC_VARIANT")] EC_VARIANT* StatusValueBuffer, [NativeTypeName("PDWORD")] uint* StatusValueBufferUsed);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcRetrySubscription([NativeTypeName("LPCWSTR")] ushort* SubscriptionName, [NativeTypeName("LPCWSTR")] ushort* EventSourceName, [NativeTypeName("DWORD")] uint Flags);

        [DllImport("wecapi", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int EcClose([NativeTypeName("EC_HANDLE")] IntPtr Object);

        [NativeTypeName("#define EC_VARIANT_TYPE_MASK 0x7f")]
        public const int EC_VARIANT_TYPE_MASK = 0x7f;

        [NativeTypeName("#define EC_VARIANT_TYPE_ARRAY 128")]
        public const int EC_VARIANT_TYPE_ARRAY = 128;

        [NativeTypeName("#define EC_READ_ACCESS 1")]
        public const int EC_READ_ACCESS = 1;

        [NativeTypeName("#define EC_WRITE_ACCESS 2")]
        public const int EC_WRITE_ACCESS = 2;

        [NativeTypeName("#define EC_OPEN_ALWAYS 0")]
        public const int EC_OPEN_ALWAYS = 0;

        [NativeTypeName("#define EC_CREATE_NEW 1")]
        public const int EC_CREATE_NEW = 1;

        [NativeTypeName("#define EC_OPEN_EXISTING 2")]
        public const int EC_OPEN_EXISTING = 2;
    }
}
