/*
// Copyright 2016 Intel Corporation All Rights Reserved.
//
//
// This software and the related documents are Intel copyrighted materials, and your use of them is governed by
// the express license under which they were provided to you ('License'). Unless the License provides otherwise,
// you may not use, modify, copy, publish, distribute, disclose or transmit this software or the related
// documents without Intel's prior written permission.
// This software and the related documents are provided as is, with no express or implied warranties, other than
// those that are expressly stated in the License.
//
*/

/*
//              Intel(R) Integrated Performance Primitives (Intel(R) IPP)
//              Image Processing (ippIP_TL)
//
//
*/


#if !defined( IPPI_TL_REDEFS__ )
#define IPPI_TL_REDEFS__

#define   ippiAdd_8u_C1RSfs_L       ippiAdd_8u_C1RSfs_LT
#define   ippiAdd_8u_C3RSfs_L       ippiAdd_8u_C3RSfs_LT
#define   ippiAdd_8u_C4RSfs_L       ippiAdd_8u_C4RSfs_LT
#define   ippiAdd_8u_AC4RSfs_L      ippiAdd_8u_AC4RSfs_LT
#define   ippiAdd_16u_C1RSfs_L      ippiAdd_16u_C1RSfs_LT
#define   ippiAdd_16u_C3RSfs_L      ippiAdd_16u_C3RSfs_LT
#define   ippiAdd_16u_C4RSfs_L      ippiAdd_16u_C4RSfs_LT
#define   ippiAdd_16u_AC4RSfs_L     ippiAdd_16u_AC4RSfs_LT
#define   ippiAdd_16s_C1RSfs_L      ippiAdd_16s_C1RSfs_LT
#define   ippiAdd_16s_C3RSfs_L      ippiAdd_16s_C3RSfs_LT
#define   ippiAdd_16s_C4RSfs_L      ippiAdd_16s_C4RSfs_LT
#define   ippiAdd_16s_AC4RSfs_L     ippiAdd_16s_AC4RSfs_LT

#define   ippiSub_8u_C1RSfs_L       ippiSub_8u_C1RSfs_LT
#define   ippiSub_8u_C3RSfs_L       ippiSub_8u_C3RSfs_LT
#define   ippiSub_8u_C4RSfs_L       ippiSub_8u_C4RSfs_LT
#define   ippiSub_8u_AC4RSfs_L      ippiSub_8u_AC4RSfs_LT
#define   ippiSub_16u_C1RSfs_L      ippiSub_16u_C1RSfs_LT
#define   ippiSub_16u_C3RSfs_L      ippiSub_16u_C3RSfs_LT
#define   ippiSub_16u_C4RSfs_L      ippiSub_16u_C4RSfs_LT
#define   ippiSub_16u_AC4RSfs_L     ippiSub_16u_AC4RSfs_LT
#define   ippiSub_16s_C1RSfs_L      ippiSub_16s_C1RSfs_LT
#define   ippiSub_16s_C3RSfs_L      ippiSub_16s_C3RSfs_LT
#define   ippiSub_16s_C4RSfs_L      ippiSub_16s_C4RSfs_LT
#define   ippiSub_16s_AC4RSfs_L     ippiSub_16s_AC4RSfs_LT

#define   ippiMul_8u_C1RSfs_L       ippiMul_8u_C1RSfs_LT
#define   ippiMul_8u_C3RSfs_L       ippiMul_8u_C3RSfs_LT
#define   ippiMul_8u_C4RSfs_L       ippiMul_8u_C4RSfs_LT
#define   ippiMul_8u_AC4RSfs_L      ippiMul_8u_AC4RSfs_LT
#define   ippiMul_16s_C1RSfs_L      ippiMul_16s_C1RSfs_LT
#define   ippiMul_16s_C3RSfs_L      ippiMul_16s_C3RSfs_LT
#define   ippiMul_16s_C4RSfs_L      ippiMul_16s_C4RSfs_LT
#define   ippiMul_16s_AC4RSfs_L     ippiMul_16s_AC4RSfs_LT
#define   ippiMul_16u_C1RSfs_L      ippiMul_16u_C1RSfs_LT
#define   ippiMul_16u_C3RSfs_L      ippiMul_16u_C3RSfs_LT
#define   ippiMul_16u_C4RSfs_L      ippiMul_16u_C4RSfs_LT
#define   ippiMul_16u_AC4RSfs_L     ippiMul_16u_AC4RSfs_LT

#define   ippiMulC_8u_C1RSfs_L      ippiMulC_8u_C1RSfs_LT
#define   ippiMulC_8u_C3RSfs_L      ippiMulC_8u_C3RSfs_LT
#define   ippiMulC_8u_C4RSfs_L      ippiMulC_8u_C4RSfs_LT
#define   ippiMulC_8u_AC4RSfs_L     ippiMulC_8u_AC4RSfs_LT
#define   ippiMulC_16s_C1RSfs_L     ippiMulC_16s_C1RSfs_LT
#define   ippiMulC_16s_C3RSfs_L     ippiMulC_16s_C3RSfs_LT
#define   ippiMulC_16s_C4RSfs_L     ippiMulC_16s_C4RSfs_LT
#define   ippiMulC_16s_AC4RSfs_L    ippiMulC_16s_AC4RSfs_LT
#define   ippiMulC_16u_C1RSfs_L     ippiMulC_16u_C1RSfs_LT
#define   ippiMulC_16u_C3RSfs_L     ippiMulC_16u_C3RSfs_LT
#define   ippiMulC_16u_C4RSfs_L     ippiMulC_16u_C4RSfs_LT
#define   ippiMulC_16u_AC4RSfs_L    ippiMulC_16u_AC4RSfs_LT

#define   ippiMul_8u_C1IRSfs_L      ippiMul_8u_C1IRSfs_LT
#define   ippiMul_8u_C3IRSfs_L      ippiMul_8u_C3IRSfs_LT
#define   ippiMul_8u_C4IRSfs_L      ippiMul_8u_C4IRSfs_LT
#define   ippiMul_8u_AC4IRSfs_L     ippiMul_8u_AC4IRSfs_LT
#define   ippiMul_16s_C1IRSfs_L     ippiMul_16s_C1IRSfs_LT
#define   ippiMul_16s_C3IRSfs_L     ippiMul_16s_C3IRSfs_LT
#define   ippiMul_16s_C4IRSfs_L     ippiMul_16s_C4IRSfs_LT
#define   ippiMul_16s_AC4IRSfs_L    ippiMul_16s_AC4IRSfs_LT
#define   ippiMul_16u_C1IRSfs_L     ippiMul_16u_C1IRSfs_LT
#define   ippiMul_16u_C3IRSfs_L     ippiMul_16u_C3IRSfs_LT
#define   ippiMul_16u_C4IRSfs_L     ippiMul_16u_C4IRSfs_LT
#define   ippiMul_16u_AC4IRSfs_L    ippiMul_16u_AC4IRSfs_LT

#define   ippiSub_32f_C1R_L         ippiSub_32f_C1R_LT
#define   ippiSub_32f_C3R_L         ippiSub_32f_C3R_LT
#define   ippiSub_32f_C4R_L         ippiSub_32f_C4R_LT
#define   ippiSub_32f_AC4R_L        ippiSub_32f_AC4R_LT
#define   ippiSub_32f_C1IR_L        ippiSub_32f_C1IR_LT
#define   ippiSub_32f_C3IR_L        ippiSub_32f_C3IR_LT
#define   ippiSub_32f_C4IR_L        ippiSub_32f_C4IR_LT
#define   ippiSub_32f_AC4IR_L       ippiSub_32f_AC4IR_LT

#define   ippiAdd_32f_C1R_L         ippiAdd_32f_C1R_LT
#define   ippiAdd_32f_C3R_L         ippiAdd_32f_C3R_LT
#define   ippiAdd_32f_C4R_L         ippiAdd_32f_C4R_LT
#define   ippiAdd_32f_AC4R_L        ippiAdd_32f_AC4R_LT
#define   ippiAdd_32f_C1IR_L        ippiAdd_32f_C1IR_LT
#define   ippiAdd_32f_C3IR_L        ippiAdd_32f_C3IR_LT
#define   ippiAdd_32f_C4IR_L        ippiAdd_32f_C4IR_LT
#define   ippiAdd_32f_AC4IR_L       ippiAdd_32f_AC4IR_LT

#define   ippiMulC_8u_C1IRSfs_L     ippiMulC_8u_C1IRSfs_LT
#define   ippiMulC_8u_C3IRSfs_L     ippiMulC_8u_C3IRSfs_LT
#define   ippiMulC_8u_C4IRSfs_L     ippiMulC_8u_C4IRSfs_LT
#define   ippiMulC_8u_AC4IRSfs_L    ippiMulC_8u_AC4IRSfs_LT
#define   ippiMulC_16u_C1IRSfs_L    ippiMulC_16u_C1IRSfs_LT
#define   ippiMulC_16u_C3IRSfs_L    ippiMulC_16u_C3IRSfs_LT
#define   ippiMulC_16u_C4IRSfs_L    ippiMulC_16u_C4IRSfs_LT
#define   ippiMulC_16u_AC4IRSfs_L   ippiMulC_16u_AC4IRSfs_LT
#define   ippiMulC_16s_C1IRSfs_L    ippiMulC_16s_C1IRSfs_LT
#define   ippiMulC_16s_C3IRSfs_L    ippiMulC_16s_C3IRSfs_LT
#define   ippiMulC_16s_C4IRSfs_L    ippiMulC_16s_C4IRSfs_LT
#define   ippiMulC_16s_AC4IRSfs_L   ippiMulC_16s_AC4IRSfs_LT

#define   ippiMul_32f_C1R_L         ippiMul_32f_C1R_LT
#define   ippiMul_32f_C3R_L         ippiMul_32f_C3R_LT
#define   ippiMul_32f_C4R_L         ippiMul_32f_C4R_LT
#define   ippiMul_32f_AC4R_L        ippiMul_32f_AC4R_LT
#define   ippiMul_32f_C1IR_L        ippiMul_32f_C1IR_LT
#define   ippiMul_32f_C3IR_L        ippiMul_32f_C3IR_LT
#define   ippiMul_32f_C4IR_L        ippiMul_32f_C4IR_LT
#define   ippiMul_32f_AC4IR_L       ippiMul_32f_AC4IR_LT

#define   ippiDiv_32f_C1R_L         ippiDiv_32f_C1R_LT
#define   ippiDiv_32f_C3R_L         ippiDiv_32f_C3R_LT
#define   ippiDiv_32f_C4R_L         ippiDiv_32f_C4R_LT
#define   ippiDiv_32f_AC4R_L        ippiDiv_32f_AC4R_LT
#define   ippiDiv_32f_C1IR_L        ippiDiv_32f_C1IR_LT
#define   ippiDiv_32f_C3IR_L        ippiDiv_32f_C3IR_LT
#define   ippiDiv_32f_C4IR_L        ippiDiv_32f_C4IR_LT
#define   ippiDiv_32f_AC4IR_L       ippiDiv_32f_AC4IR_LT
#define   ippiDiv_16s_C1RSfs_L      ippiDiv_16s_C1RSfs_LT
#define   ippiDiv_16s_C3RSfs_L      ippiDiv_16s_C3RSfs_LT
#define   ippiDiv_16s_C4RSfs_L      ippiDiv_16s_C4RSfs_LT
#define   ippiDiv_16s_AC4RSfs_L     ippiDiv_16s_AC4RSfs_LT
#define   ippiDiv_8u_C1RSfs_L       ippiDiv_8u_C1RSfs_LT
#define   ippiDiv_8u_C3RSfs_L       ippiDiv_8u_C3RSfs_LT
#define   ippiDiv_8u_C4RSfs_L       ippiDiv_8u_C4RSfs_LT
#define   ippiDiv_8u_AC4RSfs_L      ippiDiv_8u_AC4RSfs_LT
#define   ippiDiv_16u_C1RSfs_L      ippiDiv_16u_C1RSfs_LT
#define   ippiDiv_16u_C3RSfs_L      ippiDiv_16u_C3RSfs_LT
#define   ippiDiv_16u_C4RSfs_L      ippiDiv_16u_C4RSfs_LT
#define   ippiDiv_16u_AC4RSfs_L     ippiDiv_16u_AC4RSfs_LT

#define   ippiDivC_16s_C1RSfs_L     ippiDivC_16s_C1RSfs_LT
#define   ippiDivC_16s_C3RSfs_L     ippiDivC_16s_C3RSfs_LT
#define   ippiDivC_16s_C4RSfs_L     ippiDivC_16s_C4RSfs_LT
#define   ippiDivC_16s_AC4RSfs_L    ippiDivC_16s_AC4RSfs_LT
#define   ippiDivC_8u_C1RSfs_L      ippiDivC_8u_C1RSfs_LT
#define   ippiDivC_8u_C3RSfs_L      ippiDivC_8u_C3RSfs_LT
#define   ippiDivC_8u_C4RSfs_L      ippiDivC_8u_C4RSfs_LT
#define   ippiDivC_8u_AC4RSfs_L     ippiDivC_8u_AC4RSfs_LT
#define   ippiDivC_16u_C1RSfs_L     ippiDivC_16u_C1RSfs_LT
#define   ippiDivC_16u_C3RSfs_L     ippiDivC_16u_C3RSfs_LT
#define   ippiDivC_16u_C4RSfs_L     ippiDivC_16u_C4RSfs_LT
#define   ippiDivC_16u_AC4RSfs_L    ippiDivC_16u_AC4RSfs_LT
#define   ippiDivC_16s_C1IRSfs_L    ippiDivC_16s_C1IRSfs_LT
#define   ippiDivC_16s_C3IRSfs_L    ippiDivC_16s_C3IRSfs_LT
#define   ippiDivC_16s_C4IRSfs_L    ippiDivC_16s_C4IRSfs_LT
#define   ippiDivC_16s_AC4IRSfs_L   ippiDivC_16s_AC4IRSfs_LT
#define   ippiDivC_8u_C1IRSfs_L     ippiDivC_8u_C1IRSfs_LT
#define   ippiDivC_8u_C3IRSfs_L     ippiDivC_8u_C3IRSfs_LT
#define   ippiDivC_8u_C4IRSfs_L     ippiDivC_8u_C4IRSfs_LT
#define   ippiDivC_8u_AC4IRSfs_L    ippiDivC_8u_AC4IRSfs_LT
#define   ippiDivC_16u_C1IRSfs_L    ippiDivC_16u_C1IRSfs_LT
#define   ippiDivC_16u_C3IRSfs_L    ippiDivC_16u_C3IRSfs_LT
#define   ippiDivC_16u_C4IRSfs_L    ippiDivC_16u_C4IRSfs_LT
#define   ippiDivC_16u_AC4IRSfs_L   ippiDivC_16u_AC4IRSfs_LT
#define   ippiDivC_32f_C1R_L        ippiDivC_32f_C1R_LT
#define   ippiDivC_32f_C3R_L        ippiDivC_32f_C3R_LT
#define   ippiDivC_32f_C4R_L        ippiDivC_32f_C4R_LT
#define   ippiDivC_32f_AC4R_L       ippiDivC_32f_AC4R_LT
#define   ippiDivC_32f_C1IR_L       ippiDivC_32f_C1IR_LT
#define   ippiDivC_32f_C3IR_L       ippiDivC_32f_C3IR_LT
#define   ippiDivC_32f_C4IR_L       ippiDivC_32f_C4IR_LT
#define   ippiDivC_32f_AC4IR_L      ippiDivC_32f_AC4IR_LT

#define   ippiDiv_16s_C1IRSfs_L     ippiDiv_16s_C1IRSfs_LT
#define   ippiDiv_16s_C3IRSfs_L     ippiDiv_16s_C3IRSfs_LT
#define   ippiDiv_16s_C4IRSfs_L     ippiDiv_16s_C4IRSfs_LT
#define   ippiDiv_16s_AC4IRSfs_L    ippiDiv_16s_AC4IRSfs_LT
#define   ippiDiv_8u_C1IRSfs_L      ippiDiv_8u_C1IRSfs_LT
#define   ippiDiv_8u_C3IRSfs_L      ippiDiv_8u_C3IRSfs_LT
#define   ippiDiv_8u_C4IRSfs_L      ippiDiv_8u_C4IRSfs_LT
#define   ippiDiv_8u_AC4IRSfs_L     ippiDiv_8u_AC4IRSfs_LT
#define   ippiDiv_16u_C1IRSfs_L     ippiDiv_16u_C1IRSfs_LT
#define   ippiDiv_16u_C3IRSfs_L     ippiDiv_16u_C3IRSfs_LT
#define   ippiDiv_16u_C4IRSfs_L     ippiDiv_16u_C4IRSfs_LT
#define   ippiDiv_16u_AC4IRSfs_L    ippiDiv_16u_AC4IRSfs_LT

#define   ippiAddC_32f_C1R_L        ippiAddC_32f_C1R_LT
#define   ippiAddC_32f_C3R_L        ippiAddC_32f_C3R_LT
#define   ippiAddC_32f_C4R_L        ippiAddC_32f_C4R_LT
#define   ippiAddC_32f_AC4R_L       ippiAddC_32f_AC4R_LT

#define   ippiSubC_32f_C1R_L        ippiSubC_32f_C1R_LT
#define   ippiSubC_32f_C3R_L        ippiSubC_32f_C3R_LT
#define   ippiSubC_32f_C4R_L        ippiSubC_32f_C4R_LT
#define   ippiSubC_32f_AC4R_L       ippiSubC_32f_AC4R_LT

#define   ippiMulC_32f_C1R_L        ippiMulC_32f_C1R_LT
#define   ippiMulC_32f_C3R_L        ippiMulC_32f_C3R_LT
#define   ippiMulC_32f_C4R_L        ippiMulC_32f_C4R_LT
#define   ippiMulC_32f_AC4R_L       ippiMulC_32f_AC4R_LT

#define   ippiAddC_32f_C1IR_L       ippiAddC_32f_C1IR_LT
#define   ippiAddC_32f_C3IR_L       ippiAddC_32f_C3IR_LT
#define   ippiAddC_32f_C4IR_L       ippiAddC_32f_C4IR_LT
#define   ippiAddC_32f_AC4IR_L      ippiAddC_32f_AC4IR_LT

#define   ippiSubC_32f_C1IR_L       ippiSubC_32f_C1IR_LT
#define   ippiSubC_32f_C3IR_L       ippiSubC_32f_C3IR_LT
#define   ippiSubC_32f_C4IR_L       ippiSubC_32f_C4IR_LT
#define   ippiSubC_32f_AC4IR_L      ippiSubC_32f_AC4IR_LT

#define   ippiMulC_32f_C1IR_L       ippiMulC_32f_C1IR_LT
#define   ippiMulC_32f_C3IR_L       ippiMulC_32f_C3IR_LT
#define   ippiMulC_32f_C4IR_L       ippiMulC_32f_C4IR_LT
#define   ippiMulC_32f_AC4IR_L      ippiMulC_32f_AC4IR_LT

#define   ippiAdd_8u_C1IRSfs_L      ippiAdd_8u_C1IRSfs_LT
#define   ippiAdd_8u_C3IRSfs_L      ippiAdd_8u_C3IRSfs_LT
#define   ippiAdd_8u_C4IRSfs_L      ippiAdd_8u_C4IRSfs_LT
#define   ippiAdd_8u_AC4IRSfs_L     ippiAdd_8u_AC4IRSfs_LT
#define   ippiAdd_16s_C1IRSfs_L     ippiAdd_16s_C1IRSfs_LT
#define   ippiAdd_16s_C3IRSfs_L     ippiAdd_16s_C3IRSfs_LT
#define   ippiAdd_16s_C4IRSfs_L     ippiAdd_16s_C4IRSfs_LT
#define   ippiAdd_16s_AC4IRSfs_L    ippiAdd_16s_AC4IRSfs_LT
#define   ippiAdd_16u_C1IRSfs_L     ippiAdd_16u_C1IRSfs_LT
#define   ippiAdd_16u_C3IRSfs_L     ippiAdd_16u_C3IRSfs_LT
#define   ippiAdd_16u_C4IRSfs_L     ippiAdd_16u_C4IRSfs_LT
#define   ippiAdd_16u_AC4IRSfs_L    ippiAdd_16u_AC4IRSfs_LT

#define   ippiSub_8u_C1IRSfs_L      ippiSub_8u_C1IRSfs_LT
#define   ippiSub_8u_C3IRSfs_L      ippiSub_8u_C3IRSfs_LT
#define   ippiSub_8u_C4IRSfs_L      ippiSub_8u_C4IRSfs_LT
#define   ippiSub_8u_AC4IRSfs_L     ippiSub_8u_AC4IRSfs_LT
#define   ippiSub_16s_C1IRSfs_L     ippiSub_16s_C1IRSfs_LT
#define   ippiSub_16s_C3IRSfs_L     ippiSub_16s_C3IRSfs_LT
#define   ippiSub_16s_C4IRSfs_L     ippiSub_16s_C4IRSfs_LT
#define   ippiSub_16s_AC4IRSfs_L    ippiSub_16s_AC4IRSfs_LT
#define   ippiSub_16u_C1IRSfs_L     ippiSub_16u_C1IRSfs_LT
#define   ippiSub_16u_C3IRSfs_L     ippiSub_16u_C3IRSfs_LT
#define   ippiSub_16u_C4IRSfs_L     ippiSub_16u_C4IRSfs_LT
#define   ippiSub_16u_AC4IRSfs_L    ippiSub_16u_AC4IRSfs_LT

#define   ippiAddC_8u_C1RSfs_L      ippiAddC_8u_C1RSfs_LT
#define   ippiAddC_8u_C3RSfs_L      ippiAddC_8u_C3RSfs_LT
#define   ippiAddC_8u_C4RSfs_L      ippiAddC_8u_C4RSfs_LT
#define   ippiAddC_8u_AC4RSfs_L     ippiAddC_8u_AC4RSfs_LT
#define   ippiAddC_16s_C1RSfs_L     ippiAddC_16s_C1RSfs_LT
#define   ippiAddC_16s_C3RSfs_L     ippiAddC_16s_C3RSfs_LT
#define   ippiAddC_16s_C4RSfs_L     ippiAddC_16s_C4RSfs_LT
#define   ippiAddC_16s_AC4RSfs_L    ippiAddC_16s_AC4RSfs_LT
#define   ippiAddC_16u_C1RSfs_L     ippiAddC_16u_C1RSfs_LT
#define   ippiAddC_16u_C3RSfs_L     ippiAddC_16u_C3RSfs_LT
#define   ippiAddC_16u_C4RSfs_L     ippiAddC_16u_C4RSfs_LT
#define   ippiAddC_16u_AC4RSfs_L    ippiAddC_16u_AC4RSfs_LT

#define   ippiSubC_8u_C1RSfs_L      ippiSubC_8u_C1RSfs_LT
#define   ippiSubC_8u_C3RSfs_L      ippiSubC_8u_C3RSfs_LT
#define   ippiSubC_8u_C4RSfs_L      ippiSubC_8u_C4RSfs_LT
#define   ippiSubC_8u_AC4RSfs_L     ippiSubC_8u_AC4RSfs_LT
#define   ippiSubC_16s_C1RSfs_L     ippiSubC_16s_C1RSfs_LT
#define   ippiSubC_16s_C3RSfs_L     ippiSubC_16s_C3RSfs_LT
#define   ippiSubC_16s_C4RSfs_L     ippiSubC_16s_C4RSfs_LT
#define   ippiSubC_16s_AC4RSfs_L    ippiSubC_16s_AC4RSfs_LT
#define   ippiSubC_16u_C1RSfs_L     ippiSubC_16u_C1RSfs_LT
#define   ippiSubC_16u_C3RSfs_L     ippiSubC_16u_C3RSfs_LT
#define   ippiSubC_16u_C4RSfs_L     ippiSubC_16u_C4RSfs_LT
#define   ippiSubC_16u_AC4RSfs_L    ippiSubC_16u_AC4RSfs_LT

#define   ippiAddC_8u_C1IRSfs_L     ippiAddC_8u_C1IRSfs_LT
#define   ippiAddC_8u_C3IRSfs_L     ippiAddC_8u_C3IRSfs_LT
#define   ippiAddC_8u_C4IRSfs_L     ippiAddC_8u_C4IRSfs_LT
#define   ippiAddC_8u_AC4IRSfs_L    ippiAddC_8u_AC4IRSfs_LT
#define   ippiAddC_16s_C1IRSfs_L    ippiAddC_16s_C1IRSfs_LT
#define   ippiAddC_16s_C3IRSfs_L    ippiAddC_16s_C3IRSfs_LT
#define   ippiAddC_16s_C4IRSfs_L    ippiAddC_16s_C4IRSfs_LT
#define   ippiAddC_16s_AC4IRSfs_L   ippiAddC_16s_AC4IRSfs_LT
#define   ippiAddC_16u_C1IRSfs_L    ippiAddC_16u_C1IRSfs_LT
#define   ippiAddC_16u_C3IRSfs_L    ippiAddC_16u_C3IRSfs_LT
#define   ippiAddC_16u_C4IRSfs_L    ippiAddC_16u_C4IRSfs_LT
#define   ippiAddC_16u_AC4IRSfs_L   ippiAddC_16u_AC4IRSfs_LT

#define   ippiSubC_8u_C1IRSfs_L     ippiSubC_8u_C1IRSfs_LT
#define   ippiSubC_8u_C3IRSfs_L     ippiSubC_8u_C3IRSfs_LT
#define   ippiSubC_8u_C4IRSfs_L     ippiSubC_8u_C4IRSfs_LT
#define   ippiSubC_8u_AC4IRSfs_L    ippiSubC_8u_AC4IRSfs_LT
#define   ippiSubC_16s_C1IRSfs_L    ippiSubC_16s_C1IRSfs_LT
#define   ippiSubC_16s_C3IRSfs_L    ippiSubC_16s_C3IRSfs_LT
#define   ippiSubC_16s_C4IRSfs_L    ippiSubC_16s_C4IRSfs_LT
#define   ippiSubC_16s_AC4IRSfs_L   ippiSubC_16s_AC4IRSfs_LT
#define   ippiSubC_16u_C1IRSfs_L    ippiSubC_16u_C1IRSfs_LT
#define   ippiSubC_16u_C3IRSfs_L    ippiSubC_16u_C3IRSfs_LT
#define   ippiSubC_16u_C4IRSfs_L    ippiSubC_16u_C4IRSfs_LT
#define   ippiSubC_16u_AC4IRSfs_L   ippiSubC_16u_AC4IRSfs_LT

#define ippiAdd_16s_C1IRSfs ippiAdd_16s_C1IRSfs_T
#define ippiAdd_16s_C3IRSfs ippiAdd_16s_C3IRSfs_T
#define ippiAdd_16s_C4IRSfs ippiAdd_16s_C4IRSfs_T

#define ippiCrossCorrNorm_8u_C1RSfs ippiCrossCorrNorm_8u_C1RSfs_T
#define ippiCrossCorrNorm_8u32f_C1R ippiCrossCorrNorm_8u32f_C1R_T
#define ippiCrossCorrNorm_16u32f_C1R ippiCrossCorrNorm_16u32f_C1R_T
#define ippiCrossCorrNorm_32f_C1R ippiCrossCorrNorm_32f_C1R_T

#define ippiSqr_16s_C1IRSfs ippiSqr_16s_C1IRSfs_T
#define ippiSqrt_16s_C1IRSfs ippiSqrt_16s_C1IRSfs_T

#define ippiFilterILS_8u_C1R ippiFilterILS_8u_C1R_T
#define ippiFilterILS_8u_C3R ippiFilterILS_8u_C3R_T
#define ippiFilterILSInit ippiFilterILSInit_T
#define ippiFilterILSGetBufferSize ippiFilterILSGetBufferSize_T

#define ippiFilterSobelHorizBorderGetBufferSize ippiFilterSobelHorizBorderGetBufferSize_T
#define ippiFilterSobelVertBorderGetBufferSize ippiFilterSobelVertBorderGetBufferSize_T
#define ippiFilterSobelHorizBorder_8u16s_C1R ippiFilterSobelHorizBorder_8u16s_C1R_T
#define ippiFilterSobelVertBorder_8u16s_C1R ippiFilterSobelVertBorder_8u16s_C1R_T
#define ippiFilterSobelGetBufferSize ippiFilterSobelGetBufferSize_T
#define ippiFilterSobel_8u16s_C1R ippiFilterSobel_8u16s_C1R_T

#define ippiFilterMedianBorderGetBufferSize ippiFilterMedianBorderGetBufferSize_T
#define ippiFilterMedianBorder_8u_C1R ippiFilterMedianBorder_8u_C1R_T
#define ippiFilterMedianBorder_8u_C3R ippiFilterMedianBorder_8u_C3R_T
#define ippiFilterMedianBorder_8u_AC4R ippiFilterMedianBorder_8u_AC4R_T
#define ippiFilterMedianBorder_8u_C4R ippiFilterMedianBorder_8u_C4R_T

#define ippiFilterBilateralBorderGetBufferSize_L ippiFilterBilateralBorderGetBufferSize_LT
#define ippiFilterBilateralGetBufferSize ippiFilterBilateralGetBufferSize_T
#define ippiFilterBilateralGetBufferSize_L ippiFilterBilateralGetBufferSize_LT

#define ippiResizeGetSize_L ippiResizeGetSize_LT

#define ipprFilterBorderGetSize_L ipprFilterBorderGetSize_LT
#define ipprFilterBorderGetSize ipprFilterBorderGetSize_T

#define ipprFilterMedianGetSize ipprFilterMedianGetSize_T


#define IppiResizeSpec IppiResizeSpec_LT
#define ippiResizeGetBorderSize_L ippiResizeGetBorderSize_LT
#define ippiResizeGetBufferSize_L ippiResizeGetBufferSize_LT_Proxy

#define   ippiResizeNearestInit_L               ippiResizeNearestInit_C4R_LT
#define   ippiResizeLinearInit_L                ippiResizeLinearInit_C4R_LT
#define   ippiResizeCubicInit_L                 ippiResizeCubicInit_C4R_LT
#define   ippiResizeLanczosInit_L               ippiResizeLanczosInit_C4R_LT
#define   ippiResizeSuperInit_L                 ippiResizeSuperInit_C4R_LT
#define   ippiResizeAntialiasingLinearInit_L    ippiResizeAntialiasingLinearInit_C4R_LT
#define   ippiResizeAntialiasingCubicInit_L     ippiResizeAntialiasingCubicInit_C4R_LT
#define   ippiResizeAntialiasingLanczosInit_L   ippiResizeAntialiasingLanczosInit_C4R_LT

#define ippiResizeNearest_8u_C1R_L ippiResizeNearest_8u_C1R_LT_Proxy
#define ippiResizeNearest_8u_C3R_L ippiResizeNearest_8u_C3R_LT_Proxy
#define ippiResizeNearest_8u_C4R_L ippiResizeNearest_8u_C4R_LT_Proxy
#define ippiResizeNearest_16u_C1R_L ippiResizeNearest_16u_C1R_LT_Proxy
#define ippiResizeNearest_16u_C3R_L ippiResizeNearest_16u_C3R_LT_Proxy
#define ippiResizeNearest_16u_C4R_L ippiResizeNearest_16u_C4R_LT_Proxy
#define ippiResizeNearest_16s_C1R_L ippiResizeNearest_16s_C1R_LT_Proxy
#define ippiResizeNearest_16s_C3R_L ippiResizeNearest_16s_C3R_LT_Proxy
#define ippiResizeNearest_16s_C4R_L ippiResizeNearest_16s_C4R_LT_Proxy
#define ippiResizeNearest_32f_C1R_L ippiResizeNearest_32f_C1R_LT_Proxy
#define ippiResizeNearest_32f_C3R_L ippiResizeNearest_32f_C3R_LT_Proxy
#define ippiResizeNearest_32f_C4R_L ippiResizeNearest_32f_C4R_LT_Proxy

#define ippiResizeLinear_8u_C1R_L ippiResizeLinear_8u_C1R_LT_Proxy
#define ippiResizeLinear_8u_C3R_L ippiResizeLinear_8u_C3R_LT_Proxy
#define ippiResizeLinear_8u_C4R_L ippiResizeLinear_8u_C4R_LT_Proxy
#define ippiResizeLinear_16u_C1R_L ippiResizeLinear_16u_C1R_LT_Proxy
#define ippiResizeLinear_16u_C3R_L ippiResizeLinear_16u_C3R_LT_Proxy
#define ippiResizeLinear_16u_C4R_L ippiResizeLinear_16u_C4R_LT_Proxy
#define ippiResizeLinear_16s_C1R_L ippiResizeLinear_16s_C1R_LT_Proxy
#define ippiResizeLinear_16s_C3R_L ippiResizeLinear_16s_C3R_LT_Proxy
#define ippiResizeLinear_16s_C4R_L ippiResizeLinear_16s_C4R_LT_Proxy
#define ippiResizeLinear_32f_C1R_L ippiResizeLinear_32f_C1R_LT_Proxy
#define ippiResizeLinear_32f_C3R_L ippiResizeLinear_32f_C3R_LT_Proxy
#define ippiResizeLinear_32f_C4R_L ippiResizeLinear_32f_C4R_LT_Proxy
#define ippiResizeLinear_64f_C1R_L ippiResizeLinear_64f_C1R_LT_Proxy
#define ippiResizeLinear_64f_C3R_L ippiResizeLinear_64f_C3R_LT_Proxy
#define ippiResizeLinear_64f_C4R_L ippiResizeLinear_64f_C4R_LT_Proxy

#define ippiResizeCubic_8u_C1R_L ippiResizeCubic_8u_C1R_LT_Proxy
#define ippiResizeCubic_8u_C3R_L ippiResizeCubic_8u_C3R_LT_Proxy
#define ippiResizeCubic_8u_C4R_L ippiResizeCubic_8u_C4R_LT_Proxy
#define ippiResizeCubic_16u_C1R_L ippiResizeCubic_16u_C1R_LT_Proxy
#define ippiResizeCubic_16u_C3R_L ippiResizeCubic_16u_C3R_LT_Proxy
#define ippiResizeCubic_16u_C4R_L ippiResizeCubic_16u_C4R_LT_Proxy
#define ippiResizeCubic_16s_C1R_L ippiResizeCubic_16s_C1R_LT_Proxy
#define ippiResizeCubic_16s_C3R_L ippiResizeCubic_16s_C3R_LT_Proxy
#define ippiResizeCubic_16s_C4R_L ippiResizeCubic_16s_C4R_LT_Proxy
#define ippiResizeCubic_32f_C1R_L ippiResizeCubic_32f_C1R_LT_Proxy
#define ippiResizeCubic_32f_C3R_L ippiResizeCubic_32f_C3R_LT_Proxy
#define ippiResizeCubic_32f_C4R_L ippiResizeCubic_32f_C4R_LT_Proxy

#define ippiResizeLanczos_8u_C1R_L ippiResizeLanczos_8u_C1R_LT_Proxy
#define ippiResizeLanczos_8u_C3R_L ippiResizeLanczos_8u_C3R_LT_Proxy
#define ippiResizeLanczos_8u_C4R_L ippiResizeLanczos_8u_C4R_LT_Proxy
#define ippiResizeLanczos_16u_C1R_L ippiResizeLanczos_16u_C1R_LT_Proxy
#define ippiResizeLanczos_16u_C3R_L ippiResizeLanczos_16u_C3R_LT_Proxy
#define ippiResizeLanczos_16u_C4R_L ippiResizeLanczos_16u_C4R_LT_Proxy
#define ippiResizeLanczos_16s_C1R_L ippiResizeLanczos_16s_C1R_LT_Proxy
#define ippiResizeLanczos_16s_C3R_L ippiResizeLanczos_16s_C3R_LT_Proxy
#define ippiResizeLanczos_16s_C4R_L ippiResizeLanczos_16s_C4R_LT_Proxy
#define ippiResizeLanczos_32f_C1R_L ippiResizeLanczos_32f_C1R_LT_Proxy
#define ippiResizeLanczos_32f_C3R_L ippiResizeLanczos_32f_C3R_LT_Proxy
#define ippiResizeLanczos_32f_C4R_L ippiResizeLanczos_32f_C4R_LT_Proxy

#define ippiResizeSuper_8u_C1R_L ippiResizeSuper_8u_C1R_LT_Proxy
#define ippiResizeSuper_8u_C3R_L ippiResizeSuper_8u_C3R_LT_Proxy
#define ippiResizeSuper_8u_C4R_L ippiResizeSuper_8u_C4R_LT_Proxy
#define ippiResizeSuper_16u_C1R_L ippiResizeSuper_16u_C1R_LT_Proxy
#define ippiResizeSuper_16u_C3R_L ippiResizeSuper_16u_C3R_LT_Proxy
#define ippiResizeSuper_16u_C4R_L ippiResizeSuper_16u_C4R_LT_Proxy
#define ippiResizeSuper_16s_C1R_L ippiResizeSuper_16s_C1R_LT_Proxy
#define ippiResizeSuper_16s_C3R_L ippiResizeSuper_16s_C3R_LT_Proxy
#define ippiResizeSuper_16s_C4R_L ippiResizeSuper_16s_C4R_LT_Proxy
#define ippiResizeSuper_32f_C1R_L ippiResizeSuper_32f_C1R_LT_Proxy
#define ippiResizeSuper_32f_C3R_L ippiResizeSuper_32f_C3R_LT_Proxy
#define ippiResizeSuper_32f_C4R_L ippiResizeSuper_32f_C4R_LT_Proxy

#define ippiResizeAntialiasing_8u_C1R_L ippiResizeAntialiasing_8u_C1R_LT_Proxy
#define ippiResizeAntialiasing_8u_C3R_L ippiResizeAntialiasing_8u_C3R_LT_Proxy
#define ippiResizeAntialiasing_8u_C4R_L ippiResizeAntialiasing_8u_C4R_LT_Proxy
#define ippiResizeAntialiasing_16u_C1R_L ippiResizeAntialiasing_16u_C1R_LT_Proxy
#define ippiResizeAntialiasing_16u_C3R_L ippiResizeAntialiasing_16u_C3R_LT_Proxy
#define ippiResizeAntialiasing_16u_C4R_L ippiResizeAntialiasing_16u_C4R_LT_Proxy
#define ippiResizeAntialiasing_16s_C1R_L ippiResizeAntialiasing_16s_C1R_LT_Proxy
#define ippiResizeAntialiasing_16s_C3R_L ippiResizeAntialiasing_16s_C3R_LT_Proxy
#define ippiResizeAntialiasing_16s_C4R_L ippiResizeAntialiasing_16s_C4R_LT_Proxy
#define ippiResizeAntialiasing_32f_C1R_L ippiResizeAntialiasing_32f_C1R_LT_Proxy
#define ippiResizeAntialiasing_32f_C3R_L ippiResizeAntialiasing_32f_C3R_LT_Proxy
#define ippiResizeAntialiasing_32f_C4R_L ippiResizeAntialiasing_32f_C4R_LT_Proxy



#define ipprFilterBorderInit_16s_L ipprFilterBorderInit_16s_LT_Proxy
#define ipprFilterBorderInit_32f_L ipprFilterBorderInit_32f_LT_Proxy
#define ipprFilterBorderInit_64f_L ipprFilterBorderInit_64f_LT_Proxy

#define ipprFilterBorder_8u_C1V_L ipprFilterBorder_8u_C1V_LT_Proxy
#define ipprFilterBorder_16s_C1V_L ipprFilterBorder_16s_C1V_LT_Proxy
#define ipprFilterBorder_16u_C1V_L ipprFilterBorder_16u_C1V_LT_Proxy
#define ipprFilterBorder_32f_C1V_L ipprFilterBorder_32f_C1V_LT_Proxy
#define ipprFilterBorder_64f_C1V_L ipprFilterBorder_64f_C1V_LT_Proxy

#define ipprFilterBorderInit_16s ipprFilterBorderInit_16s_T_Proxy
#define ipprFilterBorderInit_32f ipprFilterBorderInit_32f_T_Proxy
#define ipprFilterBorderInit_64f ipprFilterBorderInit_64f_T_Proxy

#define ipprFilterBorder_8u_C1V ipprFilterBorder_8u_C1V_T_Proxy
#define ipprFilterBorder_16s_C1V ipprFilterBorder_16s_C1V_T_Proxy
#define ipprFilterBorder_16u_C1V ipprFilterBorder_16u_C1V_T_Proxy
#define ipprFilterBorder_32f_C1V ipprFilterBorder_32f_C1V_T_Proxy
#define ipprFilterBorder_64f_C1V ipprFilterBorder_64f_C1V_T_Proxy



#define IpprFilterMedianSpec IpprFilterMedianSpec_T
#define ipprFilterMedianInit ipprFilterMedianInit_T

#define ipprFilterMedian_8u_C1V ipprFilterMedian_8u_C1V_T
#define ipprFilterMedian_16u_C1V ipprFilterMedian_16u_C1V_T
#define ipprFilterMedian_16s_C1V ipprFilterMedian_16s_C1V_T
#define ipprFilterMedian_32f_C1V ipprFilterMedian_32f_C1V_T
#define ipprFilterMedian_64f_C1V  ipprFilterMedian_64f_C1V_T



#define ippiFilterBilateralInit    ippiFilterBilateralInit_T_Proxy
#define ippiFilterBilateral_8u_C1R ippiFilterBilateral_8u_C1R_T_Proxy
#define ippiFilterBilateral_8u_C3R ippiFilterBilateral_8u_C3R_T_Proxy
#define ippiFilterBilateral_32f_C1R ippiFilterBilateral_32f_C1R_T_Proxy
#define ippiFilterBilateral_32f_C3R ippiFilterBilateral_32f_C3R_T_Proxy
#define ippiFilterBilateral_64f_C1R ippiFilterBilateral_64f_C1R_T_Proxy
#define ippiFilterBilateral_64f_C3R ippiFilterBilateral_64f_C3R_T_Proxy
#define ippiFilterBilateral_8u_P3R ippiFilterBilateral_8u_P3R_T_Proxy
#define ippiFilterBilateral_32f_P3R ippiFilterBilateral_32f_P3R_T_Proxy
#define ippiFilterBilateral_64f_P3R ippiFilterBilateral_64f_P3R_T_Proxy

#define ippiFilterBilateralInit_L ippiFilterBilateralInit_LT_Proxy
#define ippiFilterBilateral_8u_C1R_L ippiFilterBilateral_8u_C1R_LT_Proxy
#define ippiFilterBilateral_8u_C3R_L ippiFilterBilateral_8u_C3R_LT_Proxy
#define ippiFilterBilateral_32f_C1R_L ippiFilterBilateral_32f_C1R_LT_Proxy
#define ippiFilterBilateral_32f_C3R_L ippiFilterBilateral_32f_C3R_LT_Proxy
#define ippiFilterBilateral_64f_C1R_L ippiFilterBilateral_64f_C1R_LT_Proxy
#define ippiFilterBilateral_64f_C3R_L ippiFilterBilateral_64f_C3R_LT_Proxy
#define ippiFilterBilateral_8u_P3R_L ippiFilterBilateral_8u_P3R_LT_Proxy
#define ippiFilterBilateral_32f_P3R_L ippiFilterBilateral_32f_P3R_LT_Proxy
#define ippiFilterBilateral_64f_P3R_L ippiFilterBilateral_64f_P3R_LT_Proxy



#define ippiFilterBilateralBorderInit_L ippiFilterBilateralBorderInit_LT_Proxy
#define ippiFilterBilateralBorder_8u_C1R_L ippiFilterBilateralBorder_8u_C1R_LT_Proxy
#define ippiFilterBilateralBorder_8u_C3R_L ippiFilterBilateralBorder_8u_C3R_LT_Proxy


#define ipprWarpAffineGetBufSize ipprWarpAffineGetBufSize_T
#define ipprWarpAffine_8u_C1PV   ipprWarpAffine_8u_C1PV_T
#define ipprWarpAffine_16u_C1PV  ipprWarpAffine_16u_C1PV_T
#define ipprWarpAffine_32f_C1PV  ipprWarpAffine_32f_C1PV_T
#define ipprWarpAffine_8u_C1V    ipprWarpAffine_8u_C1V_T
#define ipprWarpAffine_16u_C1V   ipprWarpAffine_16u_C1V_T
#define ipprWarpAffine_32f_C1V   ipprWarpAffine_32f_C1V_T


#ifdef __cplusplus
extern "C" {
#endif

IPPAPI(IppStatus, ippiResizeNearestInit_C4R_LT, (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, IppiResizeSpec_LT* pSpec))
IPPAPI(IppStatus, ippiResizeLinearInit_C4R_LT,  (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, IppiResizeSpec_LT* pSpec))
IPPAPI(IppStatus, ippiResizeCubicInit_C4R_LT,   (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, Ipp32f valueB, Ipp32f valueC, IppiResizeSpec_LT* pSpec, Ipp8u* pInitBuf))
IPPAPI(IppStatus, ippiResizeLanczosInit_C4R_LT, (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, Ipp32u numLobes, IppiResizeSpec_LT* pSpec, Ipp8u* pInitBuf))
IPPAPI(IppStatus, ippiResizeSuperInit_C4R_LT,   (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, IppiResizeSpec_LT* pSpec))
IPPAPI(IppStatus, ippiResizeAntialiasingLinearInit_C4R_LT, (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, IppiResizeSpec_LT* pSpec, Ipp8u* pInitBuf))
IPPAPI(IppStatus, ippiResizeAntialiasingCubicInit_C4R_LT, (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, Ipp32f valueB, Ipp32f valueC, IppiResizeSpec_LT* pSpec, Ipp8u* pInitBuf))
IPPAPI(IppStatus, ippiResizeAntialiasingLanczosInit_C4R_LT, (IppiSizeL srcSize, IppiSizeL dstSize, IppDataType dataType, Ipp32u numLobes, IppiResizeSpec_LT* pSpec, Ipp8u* pInitBuf))
IPPAPI(IppStatus, ippiFilterBilateralBorderInit_LT_Proxy, (IppiFilterBilateralType filter, IppiSizeL dstRoiSize, int radius, IppDataType dataType, int numChannels, IppiDistanceMethodType distMethod, Ipp32f valSquareSigma, Ipp32f posSquareSigma, IppiFilterBilateralSpec *pSpec))
IPPAPI(IppStatus, ippiFilterBilateralBorder_8u_C1R_LT_Proxy, (const Ipp8u *pSrc, IppSizeL srcStep, Ipp8u *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, Ipp8u *pBorderValue, const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateralBorder_8u_C3R_LT_Proxy, (const Ipp8u *pSrc, IppSizeL srcStep, Ipp8u *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, Ipp8u *pBorderValue, const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateralInit_T_Proxy, (IppiFilterBilateralType filter, IppiSize dstRoiSize, int kernelWidthHeight, IppDataType dataType, int numChannels, IppiDistanceMethodType distMethod, Ipp64f valSquareSigma, Ipp64f posSquareSigma, IppiFilterBilateralSpec *pSpec))
IPPAPI(IppStatus, ippiFilterBilateral_8u_C1R_T_Proxy, (const Ipp8u *pSrc, int srcStep, Ipp8u *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_8u_C3R_T_Proxy, (const Ipp8u *pSrc, int srcStep, Ipp8u *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_C1R_T_Proxy, (const Ipp32f *pSrc, int srcStep, Ipp32f *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_C3R_T_Proxy, (const Ipp32f *pSrc, int srcStep, Ipp32f *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_C1R_T_Proxy, (const Ipp64f *pSrc, int srcStep, Ipp64f *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_C3R_T_Proxy, (const Ipp64f *pSrc, int srcStep, Ipp64f *pDst, int dstStep, IppiSize dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_8u_P3R_T_Proxy, (const Ipp8u *pSrc[3], int srcStep[3], Ipp8u *pDst[3], int dstStep[3], IppiSize dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_P3R_T_Proxy, (const Ipp32f *pSrc[3], int srcStep[3], Ipp32f *pDst[3], int dstStep[3], IppiSize dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_P3R_T_Proxy, (const Ipp64f *pSrc[3], int srcStep[3], Ipp64f *pDst[3], int dstStep[3], IppiSize dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateralInit_LT_Proxy, (IppiFilterBilateralType filter, IppiSizeL dstRoiSize, IppSizeL kernelWidthHeight, IppDataType dataType, int numChannels, IppiDistanceMethodType distMethod, Ipp64f valSquareSigma, Ipp64f posSquareSigma, IppiFilterBilateralSpec *pSpec))
IPPAPI(IppStatus, ippiFilterBilateral_8u_C1R_LT_Proxy, (const Ipp8u *pSrc, IppSizeL srcStep, Ipp8u *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_8u_C3R_LT_Proxy, (const Ipp8u *pSrc, IppSizeL srcStep, Ipp8u *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_C1R_LT_Proxy, (const Ipp32f *pSrc, IppSizeL srcStep, Ipp32f *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_C3R_LT_Proxy, (const Ipp32f *pSrc, IppSizeL srcStep, Ipp32f *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_C1R_LT_Proxy, (const Ipp64f *pSrc, IppSizeL srcStep, Ipp64f *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[1], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_C3R_LT_Proxy, (const Ipp64f *pSrc, IppSizeL srcStep, Ipp64f *pDst, IppSizeL dstStep, IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_8u_P3R_LT_Proxy, (const Ipp8u *pSrc[3], IppSizeL srcStep[3], Ipp8u *pDst[3], IppSizeL dstStep[3], IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp8u pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_32f_P3R_LT_Proxy, (const Ipp32f *pSrc[3], IppSizeL srcStep[3], Ipp32f *pDst[3], IppSizeL dstStep[3], IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp32f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiFilterBilateral_64f_P3R_LT_Proxy, (const Ipp64f *pSrc[3], IppSizeL srcStep[3], Ipp64f *pDst[3], IppSizeL dstStep[3], IppiSizeL dstRoiSize, IppiBorderType borderType, const Ipp64f pBorderValue[3], const IppiFilterBilateralSpec *pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeAntialiasing_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeGetBufferSize_LT_Proxy, (const IppiResizeSpec_LT* pSpec, IppiSizeL dstSize, Ipp32u numChannels, IppSizeL* pBufSize))
IPPAPI(IppStatus, ippiResizeNearest_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeNearest_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeSuper_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_64f_C1R_LT_Proxy, (const Ipp64f* pSrc, IppSizeL srcStep, Ipp64f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp64f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_64f_C3R_LT_Proxy, (const Ipp64f* pSrc, IppSizeL srcStep, Ipp64f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp64f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLinear_64f_C4R_LT_Proxy, (const Ipp64f* pSrc, IppSizeL srcStep, Ipp64f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp64f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeCubic_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_8u_C1R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_8u_C3R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_8u_C4R_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp8u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16u_C1R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16u_C3R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16u_C4R_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16u* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16s_C1R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16s_C3R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_16s_C4R_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp16s* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_32f_C1R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_32f_C3R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ippiResizeLanczos_32f_C4R_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstStep, IppiPointL dstOffset, IppiSizeL dstSize, IppiBorderType border, const Ipp32f* pBorderValue, const IppiResizeSpec_LT* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorderInit_16s_T_Proxy, (const Ipp16s* pKernel, IpprVolume kernelVolume, int divisor, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorderInit_32f_T_Proxy, (const Ipp32f* pKernel, IpprVolume kernelVolume, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorderInit_64f_T_Proxy, (const Ipp64f* pKernel, IpprVolume kernelVolume, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorder_8u_C1V_T_Proxy, (const Ipp8u* pSrc, int srcPlaneStep, int srcStep, Ipp8u* pDst, int dstPlaneStep, int dstStep, IpprVolume dstRoiVolume, IpprBorderType borderType, const Ipp8u borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_16s_C1V_T_Proxy, (const Ipp16s* pSrc, int srcPlaneStep, int srcStep, Ipp16s* pDst, int dstPlaneStep, int dstStep, IpprVolume dstRoiVolume, IpprBorderType borderType, const Ipp16s borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_16u_C1V_T_Proxy, (const Ipp16u* pSrc, int srcPlaneStep, int srcStep, Ipp16u* pDst, int dstPlaneStep, int dstStep, IpprVolume dstRoiVolume, IpprBorderType borderType, const Ipp16u borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_32f_C1V_T_Proxy, (const Ipp32f* pSrc, int srcPlaneStep, int srcStep, Ipp32f* pDst, int dstPlaneStep, int dstStep, IpprVolume dstRoiVolume, IpprBorderType borderType, const Ipp32f borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_64f_C1V_T_Proxy, (const Ipp64f* pSrc, int srcPlaneStep, int srcStep, Ipp64f* pDst, int dstPlaneStep, int dstStep, IpprVolume dstRoiVolume, IpprBorderType borderType, const Ipp64f borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorderInit_16s_LT_Proxy, (const Ipp16s* pKernel, IpprVolumeL kernelVolume, int divisor, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorderInit_32f_LT_Proxy, (const Ipp32f* pKernel, IpprVolumeL kernelVolume, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorderInit_64f_LT_Proxy, (const Ipp64f* pKernel, IpprVolumeL kernelVolume, IppDataType dataType, int numChannels, IpprFilterBorderSpec* pSpec))
IPPAPI(IppStatus, ipprFilterBorder_8u_C1V_LT_Proxy, (const Ipp8u* pSrc, IppSizeL srcPlaneStep, IppSizeL srcStep, Ipp8u* pDst, IppSizeL dstPlaneStep, IppSizeL dstStep, IpprVolumeL dstRoiVolume, IpprBorderType borderType, const Ipp8u borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_16s_C1V_LT_Proxy, (const Ipp16s* pSrc, IppSizeL srcPlaneStep, IppSizeL srcStep, Ipp16s* pDst, IppSizeL dstPlaneStep, IppSizeL dstStep, IpprVolumeL dstRoiVolume, IpprBorderType borderType, const Ipp16s borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_16u_C1V_LT_Proxy, (const Ipp16u* pSrc, IppSizeL srcPlaneStep, IppSizeL srcStep, Ipp16u* pDst, IppSizeL dstPlaneStep, IppSizeL dstStep, IpprVolumeL dstRoiVolume, IpprBorderType borderType, const Ipp16u borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_32f_C1V_LT_Proxy, (const Ipp32f* pSrc, IppSizeL srcPlaneStep, IppSizeL srcStep, Ipp32f* pDst, IppSizeL dstPlaneStep, IppSizeL dstStep, IpprVolumeL dstRoiVolume, IpprBorderType borderType, const Ipp32f borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))
IPPAPI(IppStatus, ipprFilterBorder_64f_C1V_LT_Proxy, (const Ipp64f* pSrc, IppSizeL srcPlaneStep, IppSizeL srcStep, Ipp64f* pDst, IppSizeL dstPlaneStep, IppSizeL dstStep, IpprVolumeL dstRoiVolume, IpprBorderType borderType, const Ipp64f borderValue[1], const IpprFilterBorderSpec* pSpec, Ipp8u* pBuffer))

#ifdef __cplusplus
}
#endif

#endif /* IPPI_TL_REDEFS__ */
